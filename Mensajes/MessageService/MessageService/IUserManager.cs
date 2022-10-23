using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessageService
{

    [ServiceContract]

    //Esto va en el estandar, el nombre de la interfaz 
    // Service Contrans que es un contrato para la red
    //Todos las clases van serializados para ser percitida fuera del programa
    interface IUserManager
    {
        [OperationContract] //Esto metodos es para que se puede acceder a la red
        int AddUser(User user); //Son clases de mi dominio, se necesitan estar ahí

        [OperationContract]
        User GetUserById(String userId);

        [OperationContract] //Oneway en un solo sentido, envia la inf y me voy :3
        int AddManager(Manager manager);

     

    }
     
   
    [DataContract] //Todas las clases que se quieren transferirr en la red deberan ser marcada como <-
    public class User
    {
        private String userName;
        private String lastName;

        [DataMember] //Para los atributos de clase para ser transferenrir en red es con <- 
        public String UserName { get { return userName; } set { userName = value; } }

        [DataMember]
        public String LastName { get { return lastName; } set { lastName = value; } }

    }
    
    [DataContract] //Es para enviar inf en la red
    public class Manager
    {
        private String userName;
        private String lastName;

        [DataMember]
        public String UserName { get { return userName; } set { userName = value; } }

        [DataMember]
        public String LastName { get { return lastName; } set { lastName = value; } }
    }
}

// Toda la clase deberan ser serializada
// Defino contrato, tipo de entrada, salida en una INTERFAZ
// PARSECLASS: Que es una clase con muchas partes, es para dividir y segmentar
// Colbat: Es una interfaz, para que un mecanismo para ejecitar acciones al cliente, sin que el 
// cliente sepa (haga algo) ejemplo el VANEO de un jugador kk, tiene listener cuando el servidor le
// diga que hacer
// RESTRICCIONES: Utilizamos TCP, 