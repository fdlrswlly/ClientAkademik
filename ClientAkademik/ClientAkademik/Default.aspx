<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientAkademik._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Sistem Akademik"></asp:Label>
    <br />
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Masukan NIM"></asp:Label>
        <asp:TextBox ID="Txt_nim" runat="server"></asp:TextBox>
        <asp:Button ID="btn_nim" runat="server" onclick="btn_nim_Click" 
            Text="Tampilkan" />
        <br />
        <asp:Label ID="lbl_msg" runat="server" Text="Data "></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Masukkan NIM"></asp:Label>
        &nbsp;<asp:TextBox ID="Txt_nn" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Masukan Nama"></asp:Label>
        &nbsp;<asp:TextBox ID="Txt_nama" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Masukan Alamat"></asp:Label>
        &nbsp;<asp:TextBox ID="Txt_alamat" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Masukan Email"></asp:Label>
        &nbsp;
        <asp:TextBox ID="Txt_email" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Masukan Nilai"></asp:Label>
        &nbsp;<asp:TextBox ID="Txt_nilai" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_simpan" runat="server" onclick="btn_simpan_Click" 
            Text="SIMPAN" />
        <asp:Button ID="btn_ubah" runat="server" onclick="btn_ubah_Click" Text="Ubah" />
        <asp:Button ID="btn_hapus" runat="server" Text="Hapus" 
            onclick="btn_hapus_Click" />
        <br />
        <br />
    
    </div>
    <asp:GridView ID="Akademik_GD" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
