<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="myOrder.aspx.cs" Inherits="WebApplication3.myOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:1000px;margin:10px auto 0px auto;text-align:center;">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="1000px">
    <Columns>
        <asp:BoundField HeaderText="订单号" DataField="Oid" />
        <asp:BoundField HeaderText="景点名称" DataField="Fname" />
        <asp:BoundField HeaderText="用户名" DataField="Uname" />
        <asp:BoundField HeaderText="支付状态" DataField="ispay" />
        <asp:BoundField HeaderText="单价" DataField="Fprice" />
        <asp:BoundField HeaderText="数量" DataField="Onum" />
        <asp:BoundField HeaderText="总价" DataField="Sumprice" />
        <asp:BoundField HeaderText="订单时间" DataField="Ostart" />

        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Oid") %>' OnClick="LinkButton1_Click">去支付</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Fname") %>' OnClick="LinkButton2_Click">去评价</asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
        </div>
</asp:Content>
