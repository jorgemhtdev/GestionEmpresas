<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GestionEmpresas.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <header>
            <div class="row">
                <hr />
                <div class="col-md-5"><img src="img/almerimatik.png" /></div>
                <input id="user" type="text" class="col-md-2" placeholder="Usuario" />
                <input id="pass" type="password" class="col-md-2 col-md-offset-1" placeholder="Contraseña" />
                <a href="#" class="btn btn-danger col-md-offset-1" role="button">Entrar</a>
            </div>
        </header>
</asp:Content>
