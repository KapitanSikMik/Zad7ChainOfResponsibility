using System;

namespace Ćwiczenie_7___Chain_of_responsibility
{
    interface IHandler
    {
        void HandleRequest(int request);
    }

    class ConcreteHandlerTechnicalProblem : IHandler
    {
        private IHandler successor;
         public void SetSuccessor (IHandler successor)
        {
            this.successor = successor;
        }

        public void HandleRequest (int request)
        {
            if (request == 1)
            {
                Console.WriteLine("Wybrano problem techniczny");
            }
            else
            {
                successor.HandleRequest(request);
            }
        }
    }

    class ConcreteHandlerBillingInquiry : IHandler
    {
        private IHandler successor;
        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }

        public void HandleRequest(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("Wybrano zapytanie o rozliczenie");
            }
            else
            {
                successor.HandleRequest(request);
            }
        }
    }

    class ConcreteHandlerGeneralInquiry : IHandler
    {
        private IHandler successor;
        public void SetSuccessor(IHandler successor)
        {
            this.successor = successor;
        }

        public void HandleRequest(int request)
        {
            if (request == 3)
            {
                Console.WriteLine("Wybrano zapytanie ogólne");
            }
            else
            {
                successor.HandleRequest(request);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var HandlerTechnicalProblem = new ConcreteHandlerTechnicalProblem();
            var HandlerBillingInquiry = new ConcreteHandlerBillingInquiry();
            var HandlerGeneralInquiry = new ConcreteHandlerGeneralInquiry();

            HandlerTechnicalProblem.SetSuccessor(HandlerBillingInquiry);
            HandlerBillingInquiry.SetSuccessor(HandlerGeneralInquiry);

            var requests = new int[] { 1, 1, 2, 3, 2, 1 };
            
            foreach (var request in requests)
            {
                Console.WriteLine($"Processing request: {request}");
                HandlerTechnicalProblem.HandleRequest(request);
            }

        }
    }
}
