<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebForm.index" %>

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
        <div id="head01">
        <div class="btnCHK">
            <input type="button" name="phanquyen" id="tddh" class="BTN" value="Add Certificate" onclick="click_TDH()"/>
        </div>
            <div class="hr"></div>
            <div class="Nhead01">
                <div class="TTCH">
                </div>
            </div>
            <div id="mid01">
            <div id="mid01">
                <div class="RDO01">
                </div>
                <div class="titileHE">
                    <div class="titlepq"><strong>Certificate</strong></div>
                    <div hidden="true" id="mdon" class="madonh"><i id="tbmdh">'.$madoh.'</i></div>
                    <div id="khag" class="makhang">
                        <input list="dsmkh" id="ackh" class="IPKH" placeholder="Choose the Reader Id" onchange="KTKH(this.value)" />
                <datalist id="dsmkh" >
                    <option value=""></option>
                </datalist>
                    </div>
                </div>
                <div class="TTPQ" id="ThTPQ">
                  <table id="tbttkh" class="tbNV" width="801" height="73" border="0">
                    <tr>
                      <td width="329"><p><strong>Reader Name :</strong> <label id="tkh"></label></p>
                      <p>&nbsp;</p></td>
                      <td width="231"><p><strong>Reader Id :</strong> <label id="mkh"></label></p>
                      <p>&nbsp;</p></td>
                      <td width="169"><p><strong>Birthday :</strong> <label id="gtkh"></label></p>
                      <p>&nbsp;</p></td>
                  </tr>
                    <tr>
                      <td><p><strong>Phone Number :</strong> <label id="sdtkh"></label></p>
                      <p>&nbsp;</p></td>
                      <td><p><strong>E-mail :</strong> <label id="mailkh"></label></p>
                      <p>&nbsp;</p></td>
                      <td>&nbsp;</td>
                  </tr>
                  <tr>
                      <td><p><strong>Address :</strong> <label id="dckh"></label></p>
                      <p>&nbsp;</p></td>
                      <td><p><strong>Oject :</strong> <label id="lkh"></label></p>
                      <p>&nbsp;</p></td>
                      <td>&nbsp;</td>
                  </tr>
                </table>
                  
                </div>
                <div class="titileDH">
                <div id="optSPA" class="optSP">
                <input list="nsp" name="tenspd" id="sapham" class="SPDAT" placeholder="Chọn mua sản phẩm" disabled="disabled"/>
                <datalist id="nsp">
                </datalist>
                <input type="button" id="btdh" class="dathang" value="Đặt Hàng" onclick="DAT_HANG();" disabled="disabled"/></div>
                </div>
            <div id="foter01">
                <div class="btnL">
                  <input type="submit" name="luu" id="LDB" class="BTN" value="Save" disabled="disabled"/>
                </div>
            </div>
&nbsp;&nbsp;&nbsp;
            </div>
            
<div class="clear"></div>
        <div id="foter">
            <label class="txt">
                Library Management team 10
                <p> <strong>Email : </strong>Library@gmail.com </p>
                <p> <strong>Phone : </strong>0948621518 </p></text>
            </label>
        </div>
    </div>
</body>
</html>