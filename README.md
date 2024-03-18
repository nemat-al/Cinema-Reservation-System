# Cinema-Reservation-System
An academic project at HIAST aimed to build a cinema reservation system. The project is written in C# programing language and Oracle Database. 

## Index
1. [About the project](#about-the-project)
2. [Database schema](#database-schema)
3. [Project Architecture](#Project-architecture)

---

## About the project
The project aims to develope a software reservation system that manages and stores all operations related to the cinema house, including hall information, movies,
show times, and others. Which helps later to obtain useful statistics for the development of work.

Description:
- The cinema has several theaters.
- Each hall contains a number of seats, and the seats are in rows, and each row has a specific number.
- Seats are numbered with the row number and seat position in a row.
- A single movie can have multiple shows at different times, and it can be shown in multiple theaters.
- We are interested in recording the data of the information personnel and following up their registrations on the reservation system.
- We are interested in storing data about the films shown (the film's genre, its name, the name of its director and most prominent actors, its description, its running time in minutes)
 
 ## Database schema
 In the following image we can find the schema of the built database.
 
![alt text](https://github.com/Nemat-Allah-Aloush/Cinema-Reservation-System/blob/main/imgs/Database%20schema.png " Database schema")

## Project Architecture
The application consists of the following layers:
- Database layer. In this layer all the tables shown in the previous figure aill be created, besides some stored functions and stored procedures.
- A layer to build connection with the database: "connectionBuilder".
- A class that calls the stored procedures and functions in a correct way: "QueryBuilder".
- Classes Layer: Each table in the database structure has a corresponding class containing variables corresponding to the table variables.
- GateWays Layer: Within this layer there are several classGateway, each of which deals with the corresponding class, in which a request is made to invoke functions that can be used to find/modify a specific data within the "QueryBuilder" and "connectionBuilder" to create a connection with the database.
- Both the Classes layer and the GateWays Layer are called the Data Access Layer.
- The forums layer that calls the functions of the GateWays classes to transform information between the user in the upper layer and the database in the last layer.

---

Note: The project with developed within a team of two.
