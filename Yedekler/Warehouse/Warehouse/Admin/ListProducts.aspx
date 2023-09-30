<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="Warehouse.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ListView ID="lv_Products" runat="server" OnItemCommand="lv_Products_ItemCommand">
        <LayoutTemplate>
    <table class="table  table-bordered" style="text-align: center; margin-left: auto; margin-top: 50px;">
        <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Category</th>
                <th scope="col">name</th>
               
                <th scope="col">stock</th>
                <th scope="col">Price</th>
                <th scope="col">activity</th>
                <th>Options</th>
                
                


            </tr>
        </thead>
        <tbody>
            <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
        </tbody>
        </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("ID") %></td>  
                <td ><%# Eval("ProductCategorys.Category") %></td>
                <td><%# Eval("name") %></td>
            
                <td><%# Eval("stock") %></td>
                <td><%# Eval("Price") %>$</td>
                <td><%# Eval("activity") %></td>
                <td style="justify-content:center; align-items:center;">
                    
                  <asp:LinkButton CssClass="btn btn-danger form-control" ID="btn_sil" runat="server" CommandName="remove" CommandArgument='<%# Eval("ID") %>'><i class="fa-solid fa-trash-can"></i> Delete</asp:LinkButton>
                    <asp:LinkButton CssClass="btn btn-info form-control" ID="btn_update" runat="server"><i class="fa-solid fa-pen-to-square"></i> Update</asp:LinkButton>
                </td>
                
            </tr>    </ItemTemplate>
       
        </asp:ListView>
</asp:Content>


