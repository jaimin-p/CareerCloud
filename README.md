# CareerCloud (Humber College - Academic Project - .NET Developer Program)
Online Job Portal Where Employers can Post Jobs and Job Seekers can apply for Jobs.

#### Tools Used : Visual Studio 2017 , MSSQL SERVER 2017

#### Core Technologies : C#.NET , T-SQL , ASP.NET MVC , RESTful Services 

##  Project Architecture
![cc1](https://user-images.githubusercontent.com/37629359/45276537-f7c56800-b490-11e8-8c30-3a836c0cb7f2.png)

## Description

### API Layer

The API layer is the connection point for client-side system to interact with the repository.  This layer will expose two sets of endpoint connectors.  Those endpoints correspond to the REST and SOAP standards. 
Using .NET, SOAP standards are implemented via the WCF libraries.  .NET has strong support for the major standards World Wide Web Consortium.  Students learn how to implement SOAP services using WCF and how to build client applications to consume those SOAP services.
REST will be implemented via .NET’s Web API libraries.  REST is very popular when developing web based applications as the requirements to parse and process REST communications are not as heavy as they are with the SOAP standard.  REST however addresses a smaller problem space then SOAP does.
 
### Business Logic Layer

The Business Logic Layer ensures that the data passed to the API is valid from a business perspective.  For example, start dates cannot occur after end dates or a date of birth cannot be greater than today.  This layer is also responsible for authenticating clients connecting to the system.
Classes in this layer will have constructors that take an interface representing the repository layer.  Utilizing dependency inversion to provide an implementation of the repository layer will demonstrate this powerful technique.   
 
### POCOs Layer

The POCOs layer acts as a bridge between the relational database  and the object-oriented programming structures (C#).
The POCOs are classes instantiated in memory that store information either on its way from the database to the client or from the client on its way to the database from the client.  
 
### Repository Layer

The Repository layer acts as a broker between the persistent storage (relational) and the object (code) layers. There are two implementations of the repository layer both of which define a common interface.  The common interface serves as a mechanism to inject either of those implementations. 
 
--------------------------------------------------------------------------------------------------------------------------
