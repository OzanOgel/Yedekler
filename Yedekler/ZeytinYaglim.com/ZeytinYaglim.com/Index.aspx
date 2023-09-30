<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ZeytinYaglim.com.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            height: 6000px;
            font-family:Calibri;
        }

        .carousel-item {
            height: 400px;
        }

        .carousel-item img {
            object-fit: cover;
            height: 100%;
            width: 100%;
        }

        .card-img-top {
            height: 100%;
            object-fit: cover;
        }

        .carousel-indicators {
            display: none;
        }

        .table {
            background-color: #f2f9e9;
        }

        .table th {
            background-color: #AFB23F;
        }

        .table td {
            background-color: rgba(202, 159, 3, 0.2);
        }

        @media (max-width: 767px) {
            .carousel-item {
                height: 200px;
            }
        }

        .row .card {
            flex-basis: 25%;
            margin-right: 10px;
            margin-bottom: 10px;
        }

        .row .card:last-child {
            margin-right: 0;
        }

        .row .card .card-img-top {
            height: 200px;
            object-fit: contain;
        }

        @media (max-width: 767px) {
            .row .card {
                flex-basis: 100%;
                margin-right: 0;
            }
        }

        .btn-satin-al {
            background-color: #AFB23F;
            color: white;
            border: none;
            padding: 5px 10px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            border-radius: 4px;
            cursor: pointer;
        }
    </style>
    <script src="Assets/angular-1.8.2/angular.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div id="carouselExampleIndicators" class="carousel slide" data-bs-ride="carousel" style="border:1px solid #B6D957">
            <ol class="carousel-indicators">
                <li data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active"></li>
                <li data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1"></li>
                <li data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="Assets/Images/slide 1.jpg" alt="Slide 1">
                </div>
                <div class="carousel-item">
                    <img src="Assets/Images/slider2.jpg" alt="Slide 2">
                </div>
                <div class="carousel-item">
                    <img src="Assets/Images/slide3.jpg" alt="Slide 3">
                </div>
            </div>
            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </a>
        </div>
    </div>
    <div class="container mt-5" style="padding-left: 50px; padding-right: 50px;">
        <div ng-app="tablo" ng-controller="controller">
            <input type="text" ng-model="search" placeholder="Arama..." class="form-control" />
            <div class="row mt-4">
                <div class="col-md-4 mb-4" ng-repeat="x in veri | filter:search">
                    <div class="card">
                        <img src="Assets/UrunFoto/{{x.Foto1}}" class="card-img-top">
                        <div class="card-body">
                            <h5 class="card-title">{{x.UrunAdi}}</h5>
                            <p class="card-text">{{x.aciklama}}</p>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">Ürün Numarası: {{x.UrunNo}}</li>
                                <li class="list-group-item">Şişe Türü: {{x.sise}}</li>
                                <li class="list-group-item">Fiyat: {{x.UrunFiyat}}</li>
                                <li class="list-group-item">Litre: {{x.litre}}</li>
                            </ul>
                            <a href="#" class="btn btn-satin-al form-control" onclick="getProductDetails({{x.UrunNo}})">Satın Al</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="table-responsive">
                <table class="table table-bordered">
                    <tr>
                        <th>Ürün Numarası</th>
                        <th>Fotoğraf</th>
                        <th>Ürün Adı</th>
                        <th>Şişe Türü</th>
                        <th>Fiyat</th>
                        <th>Açıklama</th>
                        <th>Litre</th>
                        <th>Satın al</th>
                    </tr>
                    <tr ng-repeat="x in veri | filter:search">
                        <td>{{x.UrunNo}}</td>
                        <td><img src="Assets/UrunFoto/{{x.Foto1}}" style="width:80px; height:100px;" /></td>
                        <td>{{x.UrunAdi}}</td>
                        <td>{{x.sise}}</td>
                        <td>{{x.UrunFiyat}}</td>
                        <td>{{x.aciklama}}</td>
                        <td>{{x.litre}}</td>
                        <td><a href="#" class="btn btn-satin-al">Satın Al</a></td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <script>
        var app = angular.module('tablo', []);
        app.controller('controller', function ($scope, $http) {
            $http.get('Products.json').then(function (response) {
                $scope.veri = response.data.records;
            });
        });

    </script>
  
</asp:Content>
