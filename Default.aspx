<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 1000px; height: 200px; margin: auto auto;">
        <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal">
            <ItemTemplate>

                <div style="width: 240px; height: 200px; margin:20px 20px 0px 20px;border:1px solid black;">
                    <div style="width: 200px; height: 150px;margin:10px 20px 5px 20px; ">
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Fsrc") %>' Width="200px" Height="150px" />
                    </div>
                    <div style="width: 100%; height: 30px; text-align: center; font-size: 16px;">
                            <a href="info.aspx?Fname=<%# Eval("Fname") %>"><%# Eval("Fname") %></a>
                    </div>
                </div>

            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
