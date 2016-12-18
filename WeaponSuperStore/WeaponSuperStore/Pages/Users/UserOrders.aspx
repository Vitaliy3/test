<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Users/Users.Master" AutoEventWireup="true" CodeBehind="UserOrders.aspx.cs" Inherits="WeaponSuperStore.Pages.Users.UserOrders" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="outerContainer">
        <table id="ordersTable">
            <tr>
                <th>Имя заказчика</th>
                <th>Город</th>
                <th>Заказов</th>
                <th>Сумма</th>
                <th></th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server" SelectMethod="GetUserOrders"
                ItemType="WeaponSuperStore.Models.Order">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.City %></td>
                        <td><%# TotalWeapon(Item.OrderLines).ToString() %></td>
                        <td><%# Total(Item.OrderLines).ToString("C") %> </td>
                        
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    
</asp:Content>
