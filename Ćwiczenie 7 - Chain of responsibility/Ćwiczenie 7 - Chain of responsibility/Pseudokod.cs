//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ćwiczenie_7___Chain_of_responsibility
//{
//    class Pseudokod
//    {
//        Interfejs Handler
//    Metoda HandleRequest(żądanie)

//Klasa ConcreteHandlerTechnicalProblem implementuje Handler
//    Zmienna successor
//    Metoda SetSuccessor(następca)
//        Ustaw successor na następca

//    Metoda HandleRequest(żądanie)
//        Jeśli żądanie równe 1
//            Wypisz "Wybrano problem techniczny"
//        Inaczej
//            Wywołaj HandleRequest na successor z żądaniem

//Klasa ConcreteHandlerBillingInquiry implementuje Handler
//    Zmienna successor
//    Metoda SetSuccessor(następca)
//        Ustaw successor na następca

//    Metoda HandleRequest(żądanie)
//        Jeśli żądanie równe 2
//            Wypisz "Wybrano zapytanie o rozliczenie"
//        Inaczej
//            Wywołaj HandleRequest na successor z żądaniem

//Klasa ConcreteHandlerGeneralInquiry implementuje Handler
//    Zmienna successor
//    Metoda SetSuccessor(następca)
//        Ustaw successor na następca

//    Metoda HandleRequest(żądanie)
//        Jeśli żądanie równe 3
//            Wypisz "Wybrano zapytanie ogólne"
//        Inaczej
//            Wywołaj HandleRequest na successor z żądaniem

//Program główny
//    Utwórz HandlerTechnicalProblem
//    Utwórz HandlerBillingInquiry
//    Utwórz HandlerGeneralInquiry

//    Ustaw następce HandlerTechnicalProblem na HandlerBillingInquiry
//    Ustaw następce HandlerBillingInquiry na HandlerGeneralInquiry

//    Dla każdego żądania w liście żądań { 1, 1, 2, 3, 2, 1 }
//    Wypisz "Przetwarzanie żądania: " + żądanie
//    Wywołaj HandleRequest na HandlerTechnicalProblem z żądaniem

//}
//}
