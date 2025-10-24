using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace BL
{
    public class Class1_BD
    {
//        create database prueba16octubre


//use prueba16octubre
//create table Usuario(
//IdUsuario int primary key identity(1,1),
//Nombre varchar(50) not null,
//Apellidos varchar(50),
//Edad int,
//Fecha date,

//)


//create procedure SP_Insertar
//@Nombre varchar(50),
//@Apellidos varchar(50),
//@Edad int,
//@Fecha date
//as
//begin
//insert into Usuario(Nombre, Apellidos, Edad, Fecha) values
//                   (@Nombre, @Apellidos, @Edad, @Fecha)


//end

//exec SP_Insertar 'Juan','Perez',15, '2019-12-12'


//select* from Usuario


//create procedure SP_UpdateUsuario
//@IdUsuario int,
//@Nombre varchar(50),
//@Apellidos varchar(50),
//@Edad int,
//@Fecha date
//as
//begin

//Update Usuario set Nombre = @Nombre, Apellidos = @Apellidos, Edad=@Edad , Fecha= @Fecha where IdUsuario = @IdUsuario
//end

//exec SP_UpdateUsuario 1, 'Pedro','Perez',18,'2020/02/10'

//select* from Usuario



//create procedure SP_DeleteUser
//@IdUsuario int
//as
//begin

//delete from Usuario where IdUsuario = @IdUsuario
//end

//exec SP_DeleteUser 2


//alter procedure SP_GetByID
//@IdUsuario int
//as
//begin
//select IdUsuario,Nombre,Apellidos,Edad,Fecha from Usuario where IdUsuario =@IdUsuario
//end


//exec SP_GetByID 1


//alter procedure SP_GetALL
//as
//begin
//select Nombre,Apellidos,Edad,Fecha from Usuario
//end

//exec SP_GetALL


//create view VWGetAll
//as
//select Nombre, Apellidos, Edad, Fecha, IdUsuario from Usuario
    }
}
