<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisconnectedAssgmnet.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
        <div>
             Enter Adress ID :<asp:TextBox ID="txtAdressId" runat="server"></asp:TextBox><br />

            Enter First Name : <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>    
       
       
        <br />
            Enter Last Name : <asp:TextBox ID="txtLastname" runat="server"></asp:TextBox>
       <br />
            Enter Email : <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
      <br />

            Enter Phonenumber : <asp:TextBox ID="txtPhonenumber" runat="server"></asp:TextBox>
      <br />
            Enter Age : <asp:TextBox ID="txtage" runat="server"></asp:TextBox>
      <br />
            <asp:Button ID="btnInsertaddress" runat="server" Text="Insert Adress" OnClick="btnInsertAdress_Click"></asp:Button>
       
            &nbsp;&nbsp;&nbsp;&nbsp;
           
             <asp:Button ID="btnupdate" runat="server" Text=" Update" OnClick="btnupdate_Click"></asp:Button>
       
             
       
        &nbsp;&nbsp;&nbsp;&nbsp;
           
             <asp:Button ID="btnDelete" runat="server" Text="Delete Adress" OnClick="btnDelete_Click"></asp:Button>
       
        &nbsp;&nbsp;&nbsp;&nbsp;
           
             <asp:Button ID="btnSearch" runat="server" Text="Search Adress" OnClick="btnSearch_Click"></asp:Button>
       
        &nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Label ID="lblMessage" runat="server" Text=" "></asp:Label>
       
        </div>
    </form>
</body>
</html>
