#  Amaya

#### _Amaya, 17-12-2019_

#### By _**Neha Malhotra**_

## Description

_This mvc application allow users to shop online._

## Features 

* _Users can see the product,  ingredients._
* _User Can Shop Online, make payments and select quantity of product._

## Setup/Installation Requirements

* _Git Clone https://github.com/nehamalhotra23/Amaya-Stripe.git_
* _Add appsettings.json file in the root directory

{
    "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port= ;database="Name";uid=root;pwd=" ";"
      },
    "Logging": {
      "LogLevel": {
        "Default": "Warning"
      }
    },
    "Stripe": {
      "SecretKey": "stripe secret key",
      "PublishableKey": "stripe publishable key"
    },
    "AllowedHosts": "*"
  }_
* _Run "Dotnet Restore" in terminal_
* _Run "Dotnet Build" in terminal and navigate to localhost_


## Known Bugs

_There are no known bugs._

## Support and contact details

_Contact Neha at nehamalhotra8999@gmail.com_

## Technologies Used

_Javascript, C#, .Net, MVC, Stripe API(payments)_

### License

Copyright (c) 2019 **_Neha Malhotra_**