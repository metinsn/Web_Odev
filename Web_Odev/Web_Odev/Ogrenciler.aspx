<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ogrenciler.aspx.cs" Inherits="Web_Odev.Ogrenciler" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kurs Kayıt</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <%-- Başlık --%>
            <div class="col-lg-12" style="background-color: aliceblue; border: groove; border-color: blue">
                <marguee>
                <h1 style="font-family: 'Times New Roman', Times, serif; font-size: 35px; font-style: italic">Öğrenci Kayıt</h1>
                </marguee>
            </div>
            <%-- Açılır Menü --%>
            <div class="btn-group">
                <button type="button" class="btn btn-primary">Seçenekler</button>
                <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                    <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" role="menu">
                    <li><a href="#">Kurslar</a></li>
                    <li><a href="#">Öğrenciler</a></li>
                </ul>
            </div>
            <%-- Tablo --%>
            <div class="col-lg-12">
                <table class="table table-bordered">
                    <tr>
                        <td>
                            <asp:Label ID="Etiket1" runat="server" Text="Ögrenci Adı    :" font-size=" 25px" Font-Italic="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtAdi" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                      <tr>
                        <td>
                            <asp:Label ID="Etiket2" runat="server" Text="Ögrenci Soyadı :" font-size=" 25px" Font-Italic="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtsoyadi" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                      <tr>
                        <td>
                            <asp:Label ID="Etiket3" runat="server" Text="Ögrenci Numarası :" font-size=" 25px" Font-Italic="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtno" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                      <tr>
                        <td>
                            <asp:Label ID="Etiket4" runat="server" Text="Ögrenci Kurs Adı :" font-size=" 25px" Font-Italic="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtKurs" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
        </div>

    </form>
</body>
</html>
