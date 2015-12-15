<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Complete.aspx.cs" Inherits="WebForm.Complete" %>

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/style.css" media="screen" rel="stylesheet" />
    <title></title>
</head>
<body>
    <div id="mainwap">
        <div id="head"></div>
        <div id="mid">
            <div class="Nhead01">
                <div class="TTCH">
                </div>
            </div>
            <div id="mid01">

                <div class="TTPQ" id="ThTPQ" style="border-bottom: 1px #999999 ridge;">
                    <table id="tbttkh" class="tbNV" width="801" height="73" border="0">
                        <tr>
                            <td class="auto-style1">
                                <p>
                                    <strong>Reader Name: </strong>
                                    <asp:Label ID="lblReaderName" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td class="auto-style2">
                                <p>
                                    <strong>Reader Id: </strong>
                                    <asp:Label ID="lblReaderId" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td>
                                <p>
                                    <strong>Quantity Can Borrow: </strong>
                                    <asp:Label ID="lblQuantity" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                        </tr>
                       
                    </table>

                </div>
                <div style="padding-bottom: 20px; margin-left: 75px; padding-top: 20px; text-align: center">
                    <table border="1" style="width: 90%;">
                        <tr style="background-color: #0ee440">
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Book Id"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Book Title Id"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Book Title"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblIdFirst" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblBookIdFirst" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblBookTitleFirst" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblIdSecond" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblBookIdSecond" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblBookTitleSecond" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblIdThird" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblBookIdThird" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblBookTitleThird" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
                <div style="text-align:center; padding-bottom: 20px; padding-top: 20px">
                <form id="myForm" runat="server" >
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                    <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
                    
                </form>
                    </div>
            </div>
        </div>
        <div id="foter">
            <label class="txt">
                Library Management team 10
                    <p><strong>Email : </strong>Library@gmail.com </p>
                <p><strong>Phone : </strong></p>
            </label>
        </div>
    </div>
    </div>
</body>
</html>
