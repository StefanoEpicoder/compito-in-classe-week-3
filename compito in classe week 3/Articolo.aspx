<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Articolo.aspx.cs" Inherits="compito_in_classe_week_3.Articolo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5">
        <div class="row">
            <div class="col-6">
                <asp:Image ID="ImmagineArticolo" runat="server" Width="500px"/>
            </div>
            <div class="col-6">
                <h2 id="titoloArticolo" runat="server"></h2>
                <p id="descrizioneArticolo" runat="server"></p>
                <p id="prezzoArticolo" runat="server" class="fw-bold"></p>
                <asp:Button CssClass="btn BottoneCarrello" ID="BottoneCarrello" runat="server" Text="Aggiungi al Carrello" OnClick="AggiungiAlCarrello"/>
            </div>
        </div>
    </div>
</asp:Content>