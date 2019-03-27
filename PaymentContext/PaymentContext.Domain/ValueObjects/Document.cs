using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using PaymentContext.Domain.ValueObjects.Enums;
using PaymentContext.Shared.ValueObjects;
namespace PaymentContext.Domain.ValueObjects
{

    public class Document : ValueObject
    {
        public Document(string number, EnumDocumentType type)
        {
            switch (type)
            {
                case EnumDocumentType.Cnpj:
                    //faz alguma validação
                    break;
                case EnumDocumentType.Cpf:
                    //faz alguma validação
                    break;
            }
            Number = number;
            Type = type;
        }

        public String Number { get; private set; }

        public EnumDocumentType Type { get; private set; }
    }


}