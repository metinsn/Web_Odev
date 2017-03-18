<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kurslar.aspx.cs" Inherits="Web_Odev.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Kurs Kayıt Sistemi - Kurs</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="background-color:whitesmoke">
            <%-- Başlık --%>
            <div class="col-lg-12" style="background-color: azure; border: groove; border-color: blue;text-align:center ;text-size-adjust:auto" >         
                <h1 style="font-family: 'Times New Roman', Times, serif; font-style: italic">Kurs Kayıt</h1>  
            </div>
            <%-- Açılır Menü --%>
            <div class="btn-group">
                <button type="button" class="btn btn-primary">Seçenekler</button>
                <button type="button" class="btn btn-primary dropdown-toggle" data-toggle="dropdown">
                    <span class="caret"></span>
                </button>
                <ul class="dropdown-menu" role="menu">
                    <li><a href="Kurslar.aspx">Kurslar</a></li>
                    <li><a href="Ogrenciler.aspx">Öğrenciler</a></li>
                </ul>
            </div>
            <%-- Tablo --%>
            <div class="col-lg-12" >
                <table class="table table-bordered">
                    <tr>
                        <td>
                            <asp:Label ID="Etiket1" runat="server" Text="Kurs Adı    :" Font-Size=" 25px" Font-Italic="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtkursAdi" CssClass="form-control" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Etiket2" runat="server" Text="Kurs Saati :" Font-Size=" 25px" Font-Italic="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtkurssaati" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Etiket3" runat="server" Text="Kurs Ücreti :" Font-Size=" 25px" Font-Italic="true"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtkursucreti" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="butonKaydet" runat="server" Text="Kaydet" CssClass="btn btn-block" Font-Bold="true" BackColor="Aqua" OnClick="butonKaydet_Click" />
                            <asp:Button ID="butonGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-block" Font-Bold="true" BackColor="#ff5050" OnClick="butonGuncelle_Click"  />
                        </td>
                    </tr>
                </table>
                <%-- Grid Tablo --%>
                <div class="table-responsive">
                    <table class="table table-bordered">
                        <thead style="color: slateblue">
                            <tr>
                                <th>Kurs Adı</th>
                                <th>Kurs Saati</th>
                                <th>Kurs Ücreti</th>
                                <th>Sil    -    Güncelle</th>
                            </tr>
                        </thead>
                        <tbody>
                            <asp:Repeater ID="Tekrar1" runat="server">
                                <ItemTemplate>
                                    <tr>
                                        <td><%#Eval("kursAdi") %></td>
                                        <td><%#Eval("kursUcret") %></td>
                                        <td><%#Eval("kursSaati") %></td>
                                        <td>
                                            <a href="kurslar.aspx?ID=<%#Eval("kursID") %>" class="btn btn-primary">Sil</a>
                                             <a href="kurslar.aspx?GID=<%#Eval("kursID") %>" class="btn btn-success">Güncelle</a>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
