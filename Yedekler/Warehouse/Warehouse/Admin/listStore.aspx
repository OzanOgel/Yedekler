<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="listStore.aspx.cs" Inherits="Warehouse.Admin.listStore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ListView ID="lv_store" runat="server" OnItemCommand="lv_store_ItemCommand">
        <LayoutTemplate>
    <table class="table  table-bordered" style="text-align: center; margin-left: auto; margin-top: 50px;">
        <thead>
            <tr>
                <th scope="col">ID</th>
                <th scope="col">Store</th>
              
              
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
                <td ><%# Eval("StoreName") %></td>
               
                
                <td style="justify-content:center; align-items:center;">
                    
                  <asp:LinkButton CssClass="btn btn-danger form-control" ID="btn_sil" runat="server" CommandName="remove" CommandArgument='<%# Eval("ID") %>'><i class="fa-solid fa-trash-can"></i> Delete</asp:LinkButton>
                   
                </td>
                
            </tr>    </ItemTemplate>
       
        </asp:ListView>
</asp:Content>
