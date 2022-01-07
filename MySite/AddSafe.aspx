<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddSafe.aspx.cs" Inherits="MySite.AddSafe" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:TextBox runat="server" ID="txtId" Visible="false"></asp:TextBox>

    <table border="0" width="100%">
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="课程："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                    ControlToValidate="txtName" Display="Dynamic" ErrorMessage="课程名不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="课程描述："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtKcms"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                    ControlToValidate="txtkcms" Display="Dynamic" ErrorMessage="课程描述不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="选课日期："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtXkrq" type="date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="txtxkrq" Display="Dynamic" ErrorMessage="选课日期不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td width="20px">
                <asp:Label runat="server" Text="选课学生："></asp:Label>
            </td>
            <td align="left">
                <asp:TextBox runat="server" ID="txtXkxs"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                    ControlToValidate="txtxkxs" Display="Dynamic" ErrorMessage="选课学生不能为空"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="left" width="100%">
                <asp:Button ID="btnSave" runat="server" Text="保  存"  Width="76px" OnClick="btnSave_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
