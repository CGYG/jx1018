<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="info.aspx.cs" Inherits="WebApplication3.info" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width: 1000px; margin: auto auto;">
        <div style="width: 900px; height: 650px; margin: auto auto; margin-top: 10px;">
            <p style="padding-left:300px;">
                <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="24pt"></asp:Label>
            </p>
            <div style="width: 550px; height: 650px; float: left;">
                <div>
                    <asp:Image ID="Image1" runat="server" Width="550px" Height="550px" />
                </div>
                <p style="text-align: right; color: #808080;">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </p>
            </div>
            <div style="width: 320px; height: 650px; float: left; margin-left: 15px;">
                <br />
                <br />
                票型:<asp:DropDownList ID="DropDownList1" runat="server" OnTextChanged="DropDownList1_TextChanged" AutoPostBack="True"></asp:DropDownList>
                <br />
                <br />
                价格:<asp:Label ID="Label6" runat="server"></asp:Label>
                <br />
                <br />
                Plus会员价格:<asp:Label ID="Label7" runat="server"></asp:Label>
                <br />
                <br />
                剩余票数/总票数:<asp:Label ID="Label9" runat="server"></asp:Label>/<asp:Label ID="Label8" runat="server"></asp:Label>
                <br />
                <br />
                订购数:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                注意事项:<asp:Label ID="Label5" runat="server"></asp:Label> 
                <br />
                <br />
                开放时间:
                <asp:Label ID="Label3" runat="server"></asp:Label>
                <br />
                <br />
                地址:<asp:Label ID="Label4" runat="server"></asp:Label>
                <br />
                <br />
                <p style="padding-left: 15px;">
                    <asp:Button ID="Button1" runat="server" Text="开始订购" OnClick="Button1_Click" />
                </p>
            </div>
        </div>
        <p>地图</p>
        <div style="width: 800px; height: 600px; margin: 10px auto 10px auto;">
            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("Fmap") %>' Width="800px" Height="600px" />
        </div>
        <div style="width: 950px; margin: 10px auto 10px auto;">
            <asp:DataList ID="DataList1" runat="server" Width="100%">
                <ItemTemplate>
                    <div style="width: 100%; height: 70px; margin-top: 10px; margin-bottom: 10px;">
                        <div style="width: 20%; height: 100%; float: left; text-align: center;">
                            <div>
                                <p style="font-size: 24px;">
                                    <%# Eval("Uname") %>
                                </p>
                            </div>
                            <div>
                                <p style="color: #808080;">
                                    <%# Eval("Cdate") %>
                                    <br />
                                    <%# Eval("Cscore") %>
                                </p>
                            </div>
                        </div>
                        <div style="width: 80%; height: 100%; float: right;">
                            <div>
                                <p>
                                    <%# Eval("Commentext") %>
                                </p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>
