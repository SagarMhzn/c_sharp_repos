<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lb1" runat="server" Text="Username"></asp:Label>
            <asp:textbox ID="tb1" runat="server" ></asp:textbox>
            <asp:RequiredFieldValidator ID="r1" ControlToValidate="tb1" ErrorMessage="Username cannot be empty" runat="server" ForeColor="Red"></asp:RequiredFieldValidator> <br />

            <asp:Label ID="lb2" runat="server" Text="Password"></asp:Label>
            <asp:textbox ID="tb2" runat="server" Textmode="Password"></asp:textbox>
            <asp:RequiredFieldValidator ID="r2" ControlToValidate="tb2" ErrorMessage="Password cannot be empty" runat="server" ForeColor="Red"></asp:RequiredFieldValidator> <br />

            <asp:Label ID="lb3" runat="server" Text="Repassword"></asp:Label>
            <asp:textbox ID="tb3" runat="server" textmode="Password"></asp:textbox>
            <asp:RequiredFieldValidator ID="r3" ControlToValidate="tb3" ErrorMessage="Re-Password cannot be empty" runat="server" ForeColor="Red"></asp:RequiredFieldValidator> 
            <asp:CompareValidator ID="cp1" ControlToCompare="tb2" ControlToValidate="tb3" runat="server" ValueToCompare="equal" ErrorMessage="Password and repassword need to be same" ForeColor="Red"></asp:CompareValidator><br />

            <asp:Label ID="lb4" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButton ID="rb1" runat="server" Text="Male" GroupName="gender" Checked/>
            <asp:RadioButton ID="rb2" runat="server" Text="Female" GroupName="gender" /><br />

            <asp:Label ID="lb5" runat="server" Text="Courses"></asp:Label>
            <asp:CheckBox ID="cb1" runat="server" Text="C#" checked/>
            <asp:CheckBox ID="cb2" runat="server" Text="C++" />
            <asp:CheckBox ID="cb3" runat="server" Text="Java" /><br />

            <asp:Label ID="lb6" runat="server" Text="Country"></asp:Label>
            <asp:DropDownList ID="dl1" runat="server">
                <asp:ListItem Value=""> Select any one</asp:ListItem>
                <asp:ListItem>Nepal</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>UK</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="r4" ControlToValidate="dl1" ErrorMessage="Select atleast one option" runat="server" ForeColor="Red"></asp:RequiredFieldValidator> <br />

            <asp:Button ID="bt1" runat="server" Text="Submit" OnClick="bt1_Click" />
            <asp:Button ID="bt2" runat="server" Text="Reset" OnClick="bt2_Click" />
        </div>
    </form>

    <table border="1">
        <tr>
            <td> <asp:Label ID="show_uname" runat="server" Text="Username:"></asp:Label></td>
            <td> <asp:Label ID="dis_uname" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td> <asp:Label ID="show_pass" runat="server" Text="Password:"></asp:Label></td>
            <td> <asp:Label ID="dis_pass" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td> <asp:Label ID="show_repass" runat="server" Text="Re-Password:"></asp:Label></td>
            <td> <asp:Label ID="dis_repass" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td> <asp:Label ID="show_gender" runat="server" Text="Gender:"></asp:Label></td>
            <td> <asp:Label ID="dis_gender" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td> <asp:Label ID="show_course" runat="server" Text="Courses:"></asp:Label></td>
            <td> <asp:Label ID="dis_course" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td> <asp:Label ID="show_country" runat="server" Text="Country:"></asp:Label></td>
            <td> <asp:Label ID="dis_country" runat="server" ></asp:Label></td>
        </tr>
    </table>
</body>
</html>
