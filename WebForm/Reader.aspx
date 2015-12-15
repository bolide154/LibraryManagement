<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reader.aspx.cs" Inherits="WebForm.index" %>

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="css/style.css" media="screen" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 211px;
        }
        .auto-style2 {
            width: 326px;
        }
    </style>
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

                <div class="RDO01">
                    <form runat="server" method="get">
                        <div class="titileHE" style="width: 479px;">
                            <div class="titlepq" style="margin-right: 8px"><strong>Certificate</strong></div>
                            <div hidden="true" id="mdon" class="madonh"></div>
                            <asp:TextBox ID="txtReaderId" runat="server" Height="25px" Width="198px"></asp:TextBox>

                            <asp:Button ID="btnAddReader" runat="server" Text="Button" OnClick="AddReader_Click" Height="32px" Width="65px" />

                        </div>
                    </form>

                </div>
                <div class="TTPQ" id="ThTPQ" style="border-bottom: 1px #999999 ridge;">
                    <table id="tbttkh" class="tbNV" width="801" height="73" border="0">
                        <tr>
                            <td width="329">
                                <p>
                                    <strong>Reader Name: </strong>
                                    <asp:Label ID="lblReaderName" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td class="auto-style1">
                                <p>
                                    <strong>Reader Id: </strong>
                                    <asp:Label ID="lblReaderId" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td class="auto-style2">
                                <p>
                                    <strong>Birthday: </strong>
                                    <asp:Label ID="lblDayOfBirth" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>
                                    <strong>Phone Number: </strong>
                                    <asp:Label ID="lblPhone" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td class="auto-style1">
                                <p>
                                    <strong>E-mail: </strong>
                                    <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td class="auto-style2">
                                <p>
                                    <strong>Quantity Can Borrow: </strong>
                                    <asp:Label ID="lblQuantity" runat="server" Text="Label"></asp:Label>
                                
                                </p>
                                </td>
                            <td>
                                <p>&nbsp;</p>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <p>
                                    <strong>Address: </strong>
                                    <asp:Label ID="lblAddress" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td class="auto-style1">
                                <p>
                                    <strong>Status: </strong>
                                    <asp:Label ID="lblStatus" runat="server" Text="Label"></asp:Label>
                                </p>
                                <p>&nbsp;</p>
                            </td>
                            <td class="auto-style2">&nbsp;</td>
                        </tr>
                    </table>

                </div>
                <div style="padding-bottom: 20px; margin-left: 75px; padding-top: 20px; text-align: center">
                    <form method="get" name="myForm" onsubmit="return validateForm()" action="Book.aspx">
                        <input type="submit" value="Next" />
                    </form>
                    <script type="text/javascript">
                        function validateForm() {
                            var status = "<%= lblStatus.Text %>";
                            if (status == "Good") {
                                
                                return true
                            }
                            else {
                                alert("Reader not available!");
                                return false;
                            }
                            }
                    </script>
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
