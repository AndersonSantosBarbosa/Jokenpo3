<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Jokenpo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Panel ID="PanelCadastro" runat="server">
            <div>
            Jogador 1: <asp:TextBox ID="TextBoxNomeJogador1" runat="server"></asp:TextBox><br /><br />
            Jogador 2: <asp:TextBox ID="TextBoxNomeJogador2" runat="server"></asp:TextBox><br /><br />
<%--            Rodadas: <asp:DropDownList ID="DropDownListQuantidadeRodada" runat="server">
                <asp:ListItem Selected="True" Value="3">3 Rodadas</asp:ListItem>
                <asp:ListItem Value="5">5 Rodadas</asp:ListItem>
                <asp:ListItem Value="7">7 Rodadas</asp:ListItem>
                <asp:ListItem Value="9">9 Rodadas</asp:ListItem>
                <asp:ListItem Value="11">11 Rodadas</asp:ListItem>
            </asp:DropDownList>
--%>
<br />
            <asp:Button ID="ButtonJogar" runat="server" Text="Jogar" OnClick="ButtonJogar_Click" />

    </div>
        </asp:Panel>

        <asp:Panel ID="PanelJogo" runat="server" Visible="false">


            <div><asp:Label ID="LabelResultado" runat="server" Font-Size="Larger" ForeColor="#CC0000"></asp:Label><br /><br /><br /></div>

            <div>
                <asp:HiddenField ID="HiddenFieldQuantidadeRodada" runat="server" />
                <asp:Label ID="LabelNomeJogador1" runat="server"></asp:Label><br />
                <asp:RadioButtonList ID="RadioButtonListJogador1" runat="server">
                    <asp:ListItem Selected="True">Pedra</asp:ListItem>
                    <asp:ListItem>Papel</asp:ListItem>
                    <asp:ListItem>Tesoura</asp:ListItem>
                </asp:RadioButtonList>
                <br />

                <hr />

                <br />
                <asp:Label ID="LabelNomeJogador2" runat="server"></asp:Label><br />
                <asp:RadioButtonList ID="RadioButtonListJogador2" runat="server">
                    <asp:ListItem Selected="True">Pedra</asp:ListItem>
                    <asp:ListItem>Papel</asp:ListItem>
                    <asp:ListItem>Tesoura</asp:ListItem>
                </asp:RadioButtonList>
                <br />

                <asp:Button ID="ButtonResultado" runat="server" Text="Resultado" OnClick="ButtonResultado_Click" />

            </div>
        </asp:Panel>

    
    </form>
</body>
</html>
