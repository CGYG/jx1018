<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Car.aspx.cs" Inherits="WebApplication3.Car" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 1000px; height: 200px; margin: auto auto;">
        <table style="width: 100%; height: 200px;text-align:center;">
            <tr>
                <td>用户名</td>
                <td>景点名称</td>
                <td>门票类型</td>
                <td>预定时间</td>
                <td>单价</td>
                <td>数量</td>
            </tr>
            <tr>
                <td style="height: 61px"><asp:Label ID="Labeluname" runat="server"></asp:Label></td>
                <td style="height: 61px"><asp:Label ID="Labelfixed" runat="server"></asp:Label></td>
                <td style="height: 61px"><asp:Label ID="Labeltype" runat="server"></asp:Label></td>
                <td style="height: 61px">
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
                <td style="height: 61px"><asp:Label ID="Labelprice" runat="server"></asp:Label></td>
                <td style="height: 61px">
                    <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td>总价<asp:Label ID="Labelsum" runat="server"></asp:Label></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="确认订单" OnClick="Button1_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
