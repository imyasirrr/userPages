<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <h5>You have successfully logged in to our website</h5>
    <asp:Button ID="insert" runat="server" Text="Insert" CssClass="btn btn-info" OnClick="insert_Click"  /> 
    <asp:Button ID="update" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="update_Click" /> 
    <asp:Button ID="delete" runat="server" Text="Delete" Cssclass="btn btn-warning" OnClick="delete_Click"  /> 
    <asp:Button ID="fetchData" runat="server" Text="Fetch Data" CssClass="btn btn-secondary" OnClick="fetchData_Click" /> 

    <asp:Button ID="reset_btn"  runat="server" Text="Reset" CssClass="btn btn-danger" OnClick="reset_btn_Click" Height="28px" Width="60px" />

    <br />

    <!-- GridView -->
    <div class="gridview-container">
        <asp:GridView ID="GridView1" runat="server" CssClass="auto-style1" ForeColor="#333333" GridLines="None" CellPadding="4" Height="196px" Width="422px" style="margin-left: 0px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </div>

    <!-- Your other controls -->
    <div Class="form-control ">
    <label>Name</label><br />
    <asp:TextBox ID="StudentName" runat="server" Placeholder="Name" OnTextChanged="TextBox1_TextChanged" Width="131px"></asp:TextBox> <br />
    <label>Mobile</label><br />
    <asp:TextBox ID="MobileNo" PlaceHolder="Mobile" runat="server" ></asp:TextBox>
    <br />
  <label>Fathers Name</label>  <br />
        <asp:TextBox ID="FathersName" runat="server" ></asp:TextBox>
    <br />
    <label>EmailAddress</label> <br />
    <asp:TextBox ID="Email" runat="server"  ></asp:TextBox>
    <br />
    <asp:Button ID="All_Records" runat="server" OnClick="Button1_Click" cssClass="btn btn-danger" Text="All Records" />
    <br />
        </div>
   
    
    
    
    <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="323px" Width="754px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        
    </asp:GridView>
    <br />
</asp:Content>
