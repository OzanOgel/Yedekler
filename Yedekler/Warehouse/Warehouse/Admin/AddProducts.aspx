<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="AddProducts.aspx.cs" Inherits="Warehouse.Admin.AddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .color{
            background-color:#4C72DE;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
        <div style="background-color:#4C72DE;" class="card-header">
            <h3 style="text-align:center" class="card-title">Add Products</h3>
        </div>
        <div class="card-body">
            <div class="row">
               
                
                     <div class="col-xl-6">
                         <label class="form-label">Category</label>
                        <asp:DropDownList ID="ddl_category" runat="server" CssClass="form-control dropdown"></asp:DropDownList>
                     </div>
                        
                    
                
                     <div class="col-xl-6">
                         <label class="form-label">Name</label>
                        <asp:TextBox ID="tb_name" runat="server" CssClass="form-control"></asp:TextBox>
                     </div>
               
            </div>
             <div class="row">
                <div class ="col-xl-6">
                       
                     <label class="form-label">Stock</label>
                       <asp:TextBox ID="tb_stock" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                 <div class ="col-xl-5">
                       
                     <label class="form-label">Price</label>
                       <asp:TextBox ID="tb_price" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                 <div class ="col-xl-1">
                       <div style="margin-right:30px;" class="mt-2">
                     <label class="form-label">Activity</label>
                        <asp:CheckBox ID="cb_activity" runat="server" CssClass="form-check"></asp:CheckBox>
                           </div>
                </div>
                    </div>
            <div class="row">
                <div class="mt-5">
                <div class="col-xl-12">
                    <asp:Button runat="server" ID="btn_add" OnClick="btn_add_Click" CssClass="btn btn-primary form-control " Text="Add Products" />

                </div>
                    </div>
            </div>
            <asp:Panel runat="server" ID="pnl_suc" Visible="false">
            <div class="row">
                <div class="mt-3">
                    <div class="alert alert-success">add successful</div>
                </div>
            </div>
                </asp:Panel>
            
        </div>
    </div>
    <script>
        window.onload = function () {
            var tbStock = document.getElementById('<%= tb_stock.ClientID %>');
            var tbPrice = document.getElementById('<%= tb_price.ClientID %>');

            tbStock.addEventListener('input', function () {
                this.value = this.value.replace(/[^0-9]/g, '');
            });

            tbPrice.addEventListener('input', function () {
                this.value = this.value.replace(/[^0-9.]/g, '');
            });
        };
    </script>
</asp:Content>
