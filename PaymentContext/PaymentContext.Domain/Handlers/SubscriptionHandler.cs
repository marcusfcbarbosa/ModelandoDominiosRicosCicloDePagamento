using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;
using PaymentContext.Domain.Repositorys;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Domain.Services;
using PaymentContext.Domain.ValueObjects.Enums;
using PaymentContext.Domain.Entities;
using System;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler :
    Notifiable,
    IHandler<CreateBoletoSubscriptionCommand>,
    IHandler<CreatePayPalSubscriptionCommand>,
    IHandler<CreateCreditCardSubscriptionComand>
    {
        //aqui pega o contrato, faz a injeção passando dentro do construtor e sucesso!
        private readonly IStudentRepository _studentRepository;
        private readonly IEmailService  _emailService;
        public SubscriptionHandler(IStudentRepository studentRepository,IEmailService  emailService)
        {
            _studentRepository = studentRepository;
            _emailService = emailService;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            command.Validate();
            if (command.Invalid)
            {
                AddNotifications(command);
                return new CommandResults(false, "Não foi possivel realizar a assinatura");
            }
            //valida se o documento ja esta dentro da base
            if (_studentRepository.DocumentExists(command.Document))
            {
                return new CommandResults(false, "Ester CPF, ja se encontra em uso.");
            }
            //valida se o Email ja esta dentro da base
            if (_studentRepository.EmailExists(command.Email))
            {
                return new CommandResults(false, "Ester email, ja se encontra em uso.");
            }
            //Gerar Vo
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document, EnumDocumentType.Cpf);
            var email = new Email(command.Email);
            var address = new Address(command.Street, command.Number, command.Neighborhood, command.City, command.State, command.Country, command.ZipCode);
            //Gerar as entidades

            var student = new Student(name, document, email, address);
            var subscription = new Subscription(true);
            var payment = new BoletoPayment(command.Barcode, command.BoletoNumber, command.PaidDate, null,
                command.ExpireDate, command.Total, command.TotalPaid, address, document, command.Owner, email);
            
            //Relacionamentos
            subscription.AddPayment(payment);
            student.AddSubscription(subscription);

            //Agrupar as informações
            AddNotifications(name,document,email,address,student,subscription,payment);

            if(Invalid){
                return new CommandResults(false,"Não foi possivel realizar sua asinatura");
            }
            //salvar as informaçoes
            _studentRepository.CreateSubscription(student);

            //Envia Email de boas vindas
            _emailService.Send(student.Name.ToString(),student.Email.Address,"Assinatura realizada com sucesso!");

            //_studentRepository.CreateSubscription()
            return new CommandResults(true, "Assinatura realizada com sucesso!");
        }
        public ICommandResult Handle(CreatePayPalSubscriptionCommand command)
        {
            //implementar aqui
            throw new NotImplementedException();
        }

        public ICommandResult Handle(CreateCreditCardSubscriptionComand command)
        {
            //implementar aqui
            throw new NotImplementedException();
        }
    }
}