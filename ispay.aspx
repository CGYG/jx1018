<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ispay.aspx.cs" Inherits="WebApplication3.ispay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 500px; height: 600px;">
        <asp:Image ID="Image1" runat="server" Width="500px" Height="500px" />
        <div style="padding-left:180px;">
            <asp:LinkButton ID="LinkButton2" runat="server">取消</asp:LinkButton>
            &nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server"><a href="myOrder.aspx">我的订单</a></asp:LinkButton>
        </div>
    </div>
</asp:Content>
