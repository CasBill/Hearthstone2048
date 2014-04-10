<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rank.aspx.cs" Inherits="Web.rank" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>排行榜</title>
    <link href="css/table.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>Name</th>
                <th>Score</th>
                <th>Time</th>
            </tr>
            <asp:Repeater ID="rpt_score" runat="server">
                <ItemTemplate>

                    <tr>
                        <td><%# Eval("Name")%></td>
                        <td><%# Eval("Score")%></td>
                        <td><%# Eval("Time")%></td>
                    </tr>
            
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
