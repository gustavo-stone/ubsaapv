<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nome: <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
            CPF: <asp:TextBox ID="txtCpf" runat="server"></asp:TextBox><br />
            Email: <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            Senha: <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox><br />
            CNS: <asp:TextBox ID="txtCns" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" OnClick="btnCadastrar_Click" /><br />
            <asp:Label ID="lblTeste" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
