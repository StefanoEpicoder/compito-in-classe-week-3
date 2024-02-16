<%@ Page Language="C#" MasterPageFile="~/General.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="compito_in_classe_week_3.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container my-5" id="ContenitoreGriglia" runat="server" visible="false">
        <!-- Questo div contiene una griglia che mostra gli articoli nel carrello -->
        <asp:GridView ID="GrigliaCarrello" runat="server" AutoGenerateColumns="false" ItemType="compito_in_classe_week_3.Articolo" CssClass="table table-striped">
            <Columns>
                <asp:TemplateField HeaderText="Nome Articolo">
                    <ItemTemplate>
                        <asp:Label ID="NomeArticolo" runat="server" Text="<%# Item.Nome %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Prezzo">
                    <ItemTemplate>
                        <asp:Label ID="PrezzoArticolo" runat="server" Text=""><%# Item.Prezzo.ToString("c2") %></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div class="d-flex justify-content-end align-items-center my-5">
            <!-- Questo div contiene una label che mostra la somma dei prezzi degli articoli e un bottone che cancella gli acquisti -->
            <asp:Label ID="SommaArticoli" runat="server" Text="" CssClass="mx-5" Font-Bold="true"></asp:Label><asp:Button ID="BottoneCancella" runat="server" Text="CancellaAcquisti" CssClass="btn ms-5 me-1 CancellaCarrello" OnClick="SvuotaCarrello" />
        </div>
    </div>
    <div class="my-5 d-flex justify-content-center">
    <!-- Questo div contiene una label che mostra un messaggio se il carrello è vuoto -->
    <asp:Label ID="MessaggioCarrelloVuoto" runat="server" Text="" Visible="true" CssClass="my-5 mx-5" Font-Size="XX-Large" Font-Bold="true"></asp:Label>
        </div>
</asp:Content>
