# Weather - Aplicação de Consulta Climática 🌤️

Este é um projeto ASP.NET Razor Pages que utiliza a API do [WeatherAPI](https://www.weatherapi.com/) para exibir informações climáticas de uma cidade específica.

## Funcionalidades

- Consulta de dados climáticos em tempo real.
- Exibição de informações como:
  - Nome da cidade.
  - Descrição do clima.
  - Temperatura atual.
  - Umidade.
  - Pressão atmosférica.
  - Sensação térmica.
  - Índice UV.
  - Visibilidade.
- Ícone representando as condições climáticas.

## Tecnologias Utilizadas

- **ASP.NET Razor Pages** (.NET 9)
- **C# 13.0**
- **WeatherAPI** (para dados climáticos)
- **HTML/CSS/JavaScript** (para interface do usuário)

## Pré-requisitos

Antes de executar o projeto, certifique-se de ter:

1. **SDK do .NET 9** instalado.  
   [Baixe aqui](https://dotnet.microsoft.com/download)

2. **Visual Studio 2022** (ou superior) com suporte para desenvolvimento em ASP.NET habilitado.  
   [Baixe aqui](https://visualstudio.microsoft.com/)

3. **Chave de API do WeatherAPI**.  
   [Obtenha uma chave aqui](https://www.weatherapi.com/)

4. **Git** para clonar o repositório.  
   [Baixe aqui](https://git-scm.com/)

## Como Executar o Projeto

1. **Clone o Repositório**
   
2. **Configure a Chave de API**

   No arquivo `Clima/Pages/Index.cshtml.cs`, substitua o valor da variável `apikey` pela sua chave de API:

  <--! string apikey = "YOUR-API-KEY-HERE"; -->

3. **Execute o Projeto**
Ao executar uma guia no navegador sera aberta
[http://localhost:5000]

## Estrutura do Projeto

- **Clima/Pages/Index.cshtml.cs**: Lógica para buscar e processar os dados climáticos.
- **Clima/Pages/Index.cshtml**: Página principal que exibe as informações climáticas.
- **Clima/Pages/WeatherData.cs**: Modelo que representa os dados climáticos.
- **Clima/wwwroot/**: Arquivos estáticos (CSS, JS, imagens).

## Exemplo de Uso

Ao acessar a aplicação, você verá as informações climáticas da cidade padrão (Londres). Para consultar outra cidade, adicione um parâmetro na Barra de pesquisa, como no exemplo abaixo:

![Gif](https://github.com/user-attachments/assets/b3680c35-cd95-4777-a1f4-31e76391fb04)

