<%@ Page Title="" Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="compito_in_classe_week_3.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5">
        <div class="row">
            <asp:Repeater ID="RepeaterArticoli" runat="server" ItemType="compito_in_classe_week_3.Articolo">
                <ItemTemplate>
                    <div class="col-4 d-flex justify-content-center">
                        <div class="card m-3 p-0 cards" style="width: 18rem; height: 22rem">
                            <asp:Image ID="ImmagineProdotto" runat="server" ImageUrl="<%# Item.UrlImmagine %>" CssClass="immaginiProdotti" Width="286px" />
                            <div class="card-body d-flex flex-column justify-content-between">
                                <h5 class="card-title"><%# Item.Nome %></h5>
                                  <p class="card-text fw-bold"><%# Item.Prezzo.ToString("c2") %></p>
                                <a href="Articolo.aspx?idarticolo=<%# Item.IdArticolo %>" class="btn bottoneDettagli" role="button">Dettagli</a>
                               
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
