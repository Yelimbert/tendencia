# Social
Social is a C\# application to confirm if a Social Security Number (SSN) is valid or not.

## Installation 
You must install the .NET 6.0 SDK.
<br>Run the following commands to add the Microsoft package signing key to your list of trusted keys and add the package repository.
<br>On the command line run the following commands:
<br><br>
~~~
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
~~~
The .NET SDK is what will allow us to run the application. For the installation of the SDK execute the following commands in the command line:<br>
~~~
sudo apt update
sudo apt install -y apt-transport-https
sudo apt-get install -y dotnet-sdk-6.0
~~~

### Usage
To run the application we go to the location where we want to clone the repository, with the following command:
<br><br>`cd <file directory>`<br>

<br> `git clone https://github.com/Yelimbert/tendencia.git` <br><br>

then we use the command `dotnet run` <br><br>

The program will run and then we enter a social security number and the application will confirm if it is a valid social security number or not through certain validations.