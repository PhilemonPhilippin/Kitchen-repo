Kitchen
==============

## The aim of this project 

Kitchen is a web application designed to manage recipes. I wrote this program myself in my spare time.  
I mainly worked on it for about 3 months when I was also looking for a job in April 2023.

I have the feeling that I've made the source code slightly more complicated than it needed to be.  
Lately, I've been trying to adopt a different way of working by simplifying the code I write as much as possible. This makes it easier to read, while getting the results I need in the shortest possible time.  

I hope to have the time to rewrite part of this program using this new way of working. I would also be able to port it to the LTS version .NET 8 rather than its current target version which is .NET 7.

## Architecture

This section presents the back-end server, consisting mainly of an ASP.NET API.  
I haven't separated this project into many different layers because it doesn't really have a business logic.
So I adopted a simpler architecture. The API communicates with the DAL, which is a library of classes that in turn communicates with the database located in a SQL server.  

The database is created via Entity Framework from C# code. I also took the time to write a database seed to make my application more realistic.  
This database is also accessed via Entity Framework.  

## Authentication

I've chosen to use the authentication and authorization provider Auth0. As a result, you can connect to the site via Bearer Token.  
Auth0 allows you to create an account or log in to the site completely securely.  

## Practice

I can confess to you that I also took advantage of this project to try out new things.  
For example, I created a test database with the same seed as the real database but contained in a Docker container.  
I also started to create an xUnit integration test project using this test database.  

## Link to the frontend Angular project

This repository contains only the back end.  
To examine the front end, you can consult my project created with Angular, a framework for creating web site user interfaces using TypeScript, at this address : [KitchenNG-repo](https://github.com/PhilemonPhilippin/KitchenNG-repo).