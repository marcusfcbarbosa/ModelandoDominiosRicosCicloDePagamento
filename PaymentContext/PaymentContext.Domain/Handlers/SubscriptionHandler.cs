using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;
using PaymentContext.Domain.Repositorys;

namespace PaymentContext.Domain.Handlers{
    public class SubscriptionHandler :
    Notifiable,
    IHandler<CreateBoletoSubscriptionCommand>
    {
        //aqui pega o contrato, faz a injeção passando dentro do construtor e sucesso!
        private readonly IStudentRepository _studentRepository;
        public SubscriptionHandler(IStudentRepository studentRepository){
                _studentRepository = studentRepository;
        }

        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
           
            //valida se o documento ja esta dentro da base
            //valida se o Email ja esta dentro da base
            //Gerar Vo
            //Gear as entidades
            //Aplicar validações
            //Envia Email de boas vindas
            //_studentRepository.CreateSubscription()
            return new CommandResults(true,"Assinatura realizada com sucesso!");

        }
    }
}