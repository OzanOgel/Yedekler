<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="AddOrder.aspx.cs" Inherits="Warehouse.Admin.AddOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="card">
       <div style=" background-color:#4C72DE" class="card-header">
           <h3 style="text-align:center">Add Order</h3>
       </div>
       <div class="card-body">
           <div class="row">
               <div class="col-xl-4">
                         <label class="form-label">Products</label>
                        <asp:DropDownList ID="ddl_Products" runat="server" CssClass="form-control dropdown"></asp:DropDownList>
                     </div>
                 <div class="col-xl-4">
                         <label class="form-label">Store</label>
                        <asp:DropDownList ID="ddl_store" runat="server" CssClass="form-control dropdown"></asp:DropDownList>
                     </div>
                 <div class="col-xl-4">
                         <label class="form-label">Total</label>
                        <asp:TextBox ID="tb_total" CssClass="input-group form-control" runat="server"></asp:TextBox>
                     </div>
           </div>
           <div class="row">
               <div class="mt-5">
                     <asp:Button runat="server" ID="btn_add" OnClick="btn_add_Click" CssClass="btn btn-primary form-control " Text="Add Products" />
               </div>
           </div>
           <asp:Panel ID="pnl_stock" runat="server">
           <div class="row">
               <div class="mt-2">
                    <div class="alert alert-danger">insufficient stock</div>
               </div>
           </div>
               </asp:Panel>
       </div>
   </div>
</asp:Content>
