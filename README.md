# EventSystem :computer: :calendar: :clipboard:
- For the creation of technical events in a company, it was requested to create an Event System that allows centralizing the data of all events, controlling the vacancies available, and conducting evaluations after the end of the event.
The registration of events will be done through the application itself, any user will be able to register, respecting the limit of available places.
- Para a criação de eventos técnicos em uma empresa, foi solicitado a criação de um Sistema de Eventos que permite centralizar os dados de todos os eventos, controlar as vagas disponíveis, e realizar a avaliações após a finalização do evento.
O cadastro de eventos será feito através da própria aplicação, qualquer usuário poderá se inscrever, respeitando o limite de lugares disponíveis.

## Requirements


- [x] 1. REGISTER AN EVENT

    - [x] Administrative users must have access to functionality to register a new event 
    - [x] Each Event must have the following fields:
        - [x] Name 
        - [x] Start date / time
        - [x] End Date / Time
        - [x] Location (text field)
        - [x] Description
        - [x] Limit of places
        - [x] Category
    - [x] RULES:
        - [x] All fields of the string type are mandatory and must respect the maximum character limit
        - [x]  Date / time fields are mandatory, the date of the event must be greater than today's date, and all events must begin and end at same day
        - [x]  Category is should be a listing of the available categories.
        - [x]  Every event will have a status field, which will not be displayed at creation, but that must be defined at creation, the default value will be: “Open for Registrations". 
        - [x]  The status must have the following possible values: “Open for subscriptions "," In progress "," Completed "and" Canceled".


- [x] 2. MANAGE AN EVENT

    - [x] Only administrative users should have access to this functionality, the administration should allow:
        - [x] Cancel the event. 
        - [x] View a list of participants (people who signed up for the event). 
        - [x] Indicate that a participant was present at the event.  
        - [x] Start the event. 
        - [x] Complete the event.
    - [x] RULES:
        - [x] On the day of the event it will not be possible to cancel it.
        - [x]  It will only be possible to start the event on the start day.
        - [x]  The functionality to complete the event will only be released after the event has started.
        - [x]  Only after the event has started will it be possible to indicate whether a participant is present at the event.             

- [x] 3. LIST AN EVENT
- [x] All users must have access to the list of all available events, in the event view the status of the event must be indicated.
- [x] It must be possible to search the event by category (list of options) and by date of the event.
  - [x] RULES:
       - [x] The comparison of dates should only consider the day, it should not consider the time of the event.

- [x] 4. VIEW DETAILS OF AN EVENT
- [x] All users must have access to the details of an event, where it will be possible sign up for the event, or make your assessment.
    - [x] RULES:
        - [x] It will be possible to register for the event, only if there are vacancies available.
        - [x] After the end of the event, if the person has attended (indication by the administrative user), the option to evaluate the event will be released, through comment note.
        
## Endpoints built on the basis of what was requested        

### 1. Register an event
![image](https://user-images.githubusercontent.com/48637421/116292539-34425100-a76c-11eb-8ca4-2056dad822f1.png)

### 2. Manage an event
![image](https://user-images.githubusercontent.com/48637421/116291411-eda02700-a76a-11eb-9b16-b601db8dfca7.png)
![image](https://user-images.githubusercontent.com/48637421/116291528-10cad680-a76b-11eb-938c-10378f5e69bd.png)

### 3. List an event
![image](https://user-images.githubusercontent.com/48637421/116291805-656e5180-a76b-11eb-8f87-8d5c3e379146.png)

### 4. View details of an event
![image](https://user-images.githubusercontent.com/48637421/116292196-cdbd3300-a76b-11eb-8296-82a82b837eb1.png)
![image](https://user-images.githubusercontent.com/48637421/116292461-1e349080-a76c-11eb-9def-e923dec19083.png)

### Stacks in this project

<a href="https://aws.amazon.com" target="_blank"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/amazonwebservices/amazonwebservices-original-wordmark.svg" alt="aws" width="40" height="40"/> </a> 
<a href="https://azure.microsoft.com/en-in/" target="_blank"> <img src="https://www.vectorlogo.zone/logos/microsoft_azure/microsoft_azure-icon.svg" alt="azure" width="40" height="40"/> </a>  
<a href="https://www.w3schools.com/cs/" target="_blank"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> 
<a href="https://dotnet.microsoft.com/" target="_blank"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/> </a> 
<a href="https://www.postgresql.org" target="_blank"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/postgresql/postgresql-original-wordmark.svg" alt="postgresql" width="40" height="40"/> </a> 
<a target="_blank"> <img src="https://seeklogo.com/images/S/swagger-logo-A49F73BAF4-seeklogo.com.png" alt="swagger" width="40" height="40"/> </a>

### To Run
- Open the .sln file in a Visual Studio IDE
- Build the project and execute
- Complete the final url with /swagger, some like https://localhost:44360/swagger/index.html
- See the endpoints of the project!

That's it for today. See you later! :wave::wave:
