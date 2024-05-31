<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Falzoni.Presentation.Web._Default" %>

<asp:Content ID="DefaultCssContent" ContentPlaceHolderID="CssContent" runat="server">
    <link href="/Content/Pages/Default.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div id="myCarousel" class="carousel slide" data-ride="carousel">
      <!-- Indicators -->
      <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class=""></li>
        <li data-target="#myCarousel" data-slide-to="1" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="2" class=""></li>
      </ol>
      <div class="carousel-inner" role="listbox">
        <div class="item active">
          <img class="first-slide" src="https://www.meupositivo.com.br/panoramapositivo/wp-content/uploads/2022/11/computador-para-trabalho.jpeg" alt="First slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>O Melhor da Informática!</h1>
              <p>Aqui você encontra os melhores equipamentos e acessórios para seu computador. O melhor para uso doméstico e profissional!</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Confira nossos produtos</a></p>
            </div>
          </div>
        </div>
        <div class="item">
          <img class="second-slide" src="https://img.odcdn.com.br/wp-content/uploads/2023/05/Games-Brasil-e1686075484409.jpg" alt="Second slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>A Melhor experiência gamer do mercado.</h1>
              <p>Os melhores acessórios do mercado de grandes marcas e os melhores jogos para seu console.</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Veja o nosso catálogo</a></p>
            </div>
          </div>
        </div>
        <div class="item">
          <img class="third-slide" src="https://t.ctcdn.com.br/fxGBEvOnzlWVjHwX9Csr1YT_UcA=/640x360/smart/i530763.jpeg" alt="Third slide">
          <div class="container">
            <div class="carousel-caption">
              <h1>Tudo para o seu celular.</h1>
              <p>Os melhores e mais avançados aparelhos do mercado, com os mais variados acessórios. Você só encontra aqui!</p>
              <p><a class="btn btn-lg btn-primary" href="#" role="button">Confira agora!</a></p>
            </div>
          </div>
        </div>
      </div>
      <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>

    <div class="container marketing">

      <!-- Three columns of text below the carousel -->
     <div class="card-component">
         <h3 class="card-component-title">Recomendado para você</h3>
         <div class="row">
            <div class="col-lg-4">
                <img class="img-rounded" src="data:image/jpeg;base64,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" alt="Generic placeholder image" width="250" height="250">
                <h4>Samsung Galaxy S24 Ultra</h4>
                <h2>R$ 4.999,99</h2>
            </div><!-- /.col-lg-4 -->
            <div class="col-lg-4">
                <img class="img-rounded" src="https://m.media-amazon.com/images/I/51N3W0eSxPL._AC_UF894,1000_QL80_.jpg" alt="Generic placeholder image" width="250" height="250">
                <h4>Notebook ASUS VivoBook X513EA-BQ2782W Intel Core i5 1135G7 8GB 256GB SSD W11 15,6" Full HD LED Backlit Azul</h4>
                <h2>R$ 4.698,90</h2>
            </div><!-- /.col-lg-4 -->
            <div class="col-lg-4">
                <img class="img-rounded" src="https://m.media-amazon.com/images/I/51rzWirXO4L.jpg" alt="Generic placeholder image" width="250" height="250">
                <h4>Console PlayStation 5</h4>
                <h2>R$ 3.599,90</h2>
            </div><!-- /.col-lg-4 -->
        </div><!-- /.row -->
        <div class="row">
            <div class="col-lg-4">
                <img class="img-rounded" src="https://http2.mlstatic.com/D_NQ_NP_651710-MLM51559386433_092022-O.webp" alt="Generic placeholder image" width="250" height="250">
                <h4>Apple iPhone 14 Pro Max (1 TB) - Preto espacial</h4>
                <h2>R$ 14.999,99</h2>
            </div><!-- /.col-lg-4 -->
            <div class="col-lg-4">
                <img class="img-rounded" src="https://infostore.vteximg.com.br/arquivos/ids/231874-1000-1000/2.jpg?v=637792403031870000" alt="Generic placeholder image" width="250" height="250">
                <h4>Console Nintendo Switch OLED 64GB com Joy Con Azul/Vermelho - Nintendo</h4>
            <h2>R$ 2.249,10</h2>
            </div><!-- /.col-lg-4 -->
            <div class="col-lg-4">
                <img class="img-rounded" src="https://fujiokadistribuidor.vteximg.com.br/arquivos/ids/291609" alt="Generic placeholder image" width="250" height="250">
                <h4>Controle Dualshock 4 - PlayStation 4 - Preto</h4>
                <h2>R$ 299,99</h2>
            </div><!-- /.col-lg-4 -->
        </div><!-- /.row -->
         <div class="row">
            <div class="col-lg-4">
                <img class="img-rounded" src="https://dcdn.mitiendanube.com/stores/002/981/627/products/8608d25e1df36eaea66b81a3615def16awsaccesskeyidakiatclmsgfx4j7tu445expires1690663010signaturefslo18ucpsb1f0mzajfchavpi2fs3d-3893110786a0f5f64416880710794466-640-0.webp" alt="Generic placeholder image" width="250" height="250">
                <h4>Capa de celular colorida para linha Xiaomi</h4>
                <h2>R$ 39,99</h2>
            </div><!-- /.col-lg-4 -->
            <div class="col-lg-4">
                <img class="img-rounded" src="https://cdn.dooca.store/180/products/psd-kit-gamer-02_640x640+fill_ffffff.png?v=1604595323&webp=0" alt="Generic placeholder image" width="250" height="250">
                <h4>Kit Gamer Spider Teclado + Mouse Gamer 2000DPI + Headset Gamer</h4>
            <h2>R$ 272,00</h2>
            </div><!-- /.col-lg-4 -->
            <div class="col-lg-4">
                <img class="img-rounded" src="https://cdn.shoppub.io/cdn-cgi/image/w=1000,h=1000,q=80,f=auto/oficinadosbits/media/uploads/produtos/foto/dphixwjo/file.png" alt="Generic placeholder image" width="250" height="250">
                <h4>Multifuncional HP Deskjet Ink Advantage 2774 - USB, Rede, Wi-fi - Impressora, Copiadora, Scanner</h4>
                <h2>R$ 469,99</h2>
            </div><!-- /.col-lg-4 -->
        </div><!-- /.row -->
     </div>
    </div>

</asp:Content>
