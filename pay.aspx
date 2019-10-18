<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pay.aspx.cs" Inherits="WebApplication3.pay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:400px;height:60px;margin:200px auto 0 auto; text-align:center;">
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" PostBackUrl="~/ispay.aspx" >支付宝支付</asp:LinkButton>
        </p>
        <p>
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">微信支付</asp:LinkButton>
        </p>
    </div>
</asp:Content>
