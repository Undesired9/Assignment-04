

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CIITStudents.aspx.cs" Inherits="CIITStudent.CIITStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" BorderWidth="2" BorderStyle="Solid" runat="server">
                <table border="1" style="width:500px; text-align:left;">
                    <tr>
                        <th colspan="2" style="text-align:center;">Cascading Dropdown List</th>
                    </tr>
                    <tr>
                        <td><b>Select Country</b></td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td><b>Select State</b></td>
                        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                                OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td><b>Select City</b></td>
                        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
    </div>
    </form>
</body>
</html>
