using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

@page
@model PizzaShop.Web.Pages.Pizzas.CreateModel
@using PizzaShop.Application.Pizza

<form method="post">
    <div class= "form-group" >
        < label asp -for= "Pizza.Title" ></ label >
        < input asp -for= "Pizza.Title" class= "form-control" />
        < span asp - validation -for= "Pizza.Title" class= "text-danger" ></ span >
    </ div >
    < div class= "form-group" >
        < label asp -for= "Pizza.Description" ></ label >
        < input asp -for= "Pizza.Description" class= "form-control" />
        < span asp - validation -for= "Pizza.Description" class= "text-danger" ></ span >
    </ div >
    < div class= "form-group" >
        < label asp -for= "Pizza.Price" ></ label >
        < input asp -for= "Pizza.Price" class= "form-control" />
        < span asp - validation -for= "Pizza.Price" class= "text-danger" ></ span >
    </ div >
    < button type = "submit" class= "btn btn-primary" > Dodaj pizzê </ button >
</ form >

@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}