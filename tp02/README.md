

<p><br/></p>
<p align="center"><img src="https://github.com/franciscocamellon/.net-development/blob/master/images/infnet_logo.svg" /></p>

---

<h1 align="center"> INSTITUTO INFNET <br>
ESCOLA SUPERIOR DA TECNOLOGIA DA INFORMAÇÃO<br>
CURSO DE ENGENHARIA DE SOFTWARES</h1>
<p><br></p>
<p><br></p>
<p><br></p>
<h3 align="center">Francisco Alves Camello Neto</h3>

<p><br></p>
<p><br></p>
<p><br></p>
<h3 align="center" padding-top="200"> Desenvolvimento .NET</h3>
<h4 align="center" padding-top="200"> TP02 - Projeto de Bloco</h4>
<p><br></p>
<p><br></p>
<p><br></p>
<h3 align="center">Prof. Júlio César Guimarães</h3>
<p><br></p>
<p><br></p>

---

<p align="center">Brasília<br> 14 de junho de 2021</p>
  
<p><br></p>
<p><br></p>
<p><br></p>
<p><br></p>
<p><br></p>



## <p align="center">SUMÁRIO</p>


### [Home](https://github.com/franciscocamellon/.netDevelopment_BlockProject/wiki)
### [Requisitos de sistema - Casos de Uso](hhttps://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp02/tp02#requisitos-de-sistema---casos-de-uso-1)

  

-  [UC01 - Criar perfil na rede social](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp02/tp02#uc01---criar-perfil-na-rede-social)
-  [UC02 - Autenticação na rede social](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp02/tp02#uc02---autentica%C3%A7%C3%A3o-na-rede-social)
-  [UC03 - Gerenciar portifólio](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp02/tp02#uc03---gerenciar-portif%C3%B3lio)
-  [UC04 - Pesquisar por oportunidade de trabalho](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp02/tp02#uc04---pesquisar-por-oportunidade-de-trabalho)
-  [UC08 - Gerenciar oportunidades de trabalho](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp02/tp02#uc08---gerenciar-oportunidades-de-trabalho)

<p><br></p>

---

<p><br></p>

## Requisitos de sistema - Casos de Uso  

## UC01 - Criar perfil na rede social

### Descrição:
Criar um perfil de usuário.
### Ator:
Usuário não cadastrado.
### Pré-condição:
O usuário deve possuir um endereço de email, conta no Facebook ou conta no Google+.
### Fluxo Básico:
* O usuário acessa o sistema.
* O usuário clica em "Cadastrar".
* O usuário seleciona fazer cadastro pelo endereço de email.
* O usuário define o tipo de perfil DEV ou EMPRESA.
* O usuário insere o endereço de email que deseja cadastrar.
* O Usuário preenche as informações necessárias para cada perfil DEV ou EMPRESA.
* O Usuário executa a criação do perfil.
* O sistema retorna para a página de perfil.

### Fluxo alternativo:
* O usuário se cadastra utilizando sua conta do Facebook.
    * O usuário clica em "Facebook".
    * O sistema se conecta com o site Facebook.
    * O sistema retorna para a página do perfil.
* O usuário se cadastra utilizando sua conta do Google+.
    * O usuário clica em "Google+".
    * O sistema se conecta com o site Google+.
    * O sistema retorna para a página do perfil.

### Regras de validação:
* O Usuário informa um e-mail que já está associado a algum perfil. Quando executarem a criação do perfil, a mensagem “Esse e-mail já está associado a um perfil” deverá ser exibida. 
* Confirmação de e-mail e senha: o usuário deve fornecer os dados duas vezes para minimizar o risco de erro.
* Validação de e-mail: verificar se o e-mail está em um formato válido, se o e-mail já consta na base de dados.
* Validação de senha: verificar se a senha respeita os requisitos de segurança.
### Pós   condição:
Um perfil é criado com os dados informados pelo DEV ou EMPRESA. O usuário perde acesso as funcionalidade que so podem ser acessadas por usuários cadastrados.

### Requisitos relacionados:  
Nenhum.


## UC02 - Autenticação na rede social

### Descrição:
Fazer login em uma conta de usuário já existente.
### Ator:
Usuário cadastrado.
### Pré-condição:
O usuário deve possuir um cadastro do tipo DEV ou EMPRESA.
### Fluxo Básico:
* O usuário acessa o sistema.
* O usuário clica em "Logar".
* O usuário seleciona fazer login pelo endereço de email.
* O usuário insere o seu endereço de email e sua senha.
* O sistema autentica os dados fornecidos.
* O sistema retorna para a página do perfil.

### Fluxo alternativo:
* O usuário faz login utilizando sua conta do Facebook.
    * O usuário clica em "Facebook".
    * O sistema se conecta com o site Facebook.
    * O sistema retorna para a página do perfil.
* O usuário faz login utilizando sua conta do Google+.
    * O usuário clica em "Google+".
    * O sistema se conecta com o site Google+.
    * O sistema retorna para a página do perfil.
### Regras de validação:
* Email: email válido.
* Senha: alfanumérica, mínimo 12 caracteres.
### Pós   condição :
Após a autenticação o sistema libera a navegação na rede social e habilita a edição do perfil e criação de posts. O usuário perde acesso as funcionalidade que so podem ser acessadas após o login.
### Requisitos   relacionados:
UC01.

## UC03 - Gerenciar portifólio


### Descrição: 
Configurar e/ou mudar informações de uma conta.
### Atores:
Usuário logado.
### Pré-condição:
O usuário deve estar logado em uma conta DEV ou EMPRESA.
### Fluxo Básico:
* O usuário acessa o sistema.
* O usuário clica la logo de sua imagem.
* O usuário clica em "editar".
* O usuário altera ou não campos de informações da conta.
* O usuário clica em "salvar edições".
* O usuário adiciona imagens ou vídeos de seus projetos.
* O sistema atualiza informações de usuários.

### Fluxo alternativo:
* O usuário quer deletar sua conta.
    * O usuário clica no botão "Deletar conta".
    * O sistema retorna a mensagem “Tem certeza que quer deletar sua conta?”.
    * O usuário confirma que está deletando sua conta.
    * O sistema deleta a conta do registro.
* O Usuário coloca algum dado inválido.
    * O sistema verifica o a validez dos campos alterados.
    * O sistema aponta que há campos inválidos.
* O Usuário faz upload de midias maiores que o limite.
    * O sistema verifica o tamanho dos arquivos de mídia.
    * O sistema aponta mídias fora do limite.
### Regras de validação:
* Username: Texto, máximo de 100 caracteres.
* Email: email válido.
* Projeto: texto, máximo de 100 caracteres.
* Aplicativo: link para a loja de aplicativos.
* Tecnologia utilizada: lista das tecnologias envolvidas.
* Galeria: GIF, PNG, MP4 ou JPEG, máximo 15Mb.
### Pós   condição:
Após a configuração de conta, a pagina é recarregada com as novas informações.
### Requisitos   relacionados:
UC01 e UC02.

## UC04 - Pesquisar por oportunidade de trabalho

### Descrição: 
Buscar uma oportunidade de trabalho por meio de uma palavra chave.
### Atores:
* Usuário não cadastrado
* Usuário cadastrado.
### Pré-condição:
Possuir acesso ao site DEV Network.
### Fluxo Básico:
* O usuário não cadastrado ou cadastrado insere o texto no espaço da barra de busca.
* O usuário não cadastrado ou cadastrado escolhe a linguagem de programação na lista de tecnologias.
* O usuário não cadastrado ou cadastrado pressiona a tecla "enter" do teclado ou o botão "buscar".

### Fluxo alternativo:
* Nenhuma oportunidade de trabalho relacionada com a(s) palavra(s) chave foi encontrada.
    * O sistema não retorna nenhuma oportunidade de trabalho
    * O sistema retorna a mensagem "Nenhuma oportunidade de trabalho foi encontrada para {searchTerm}!" 
### Regras de validação:
* Termo de busca: texto, máximo de 100 caracteres
* Tecnologia: texto, máximo 100 caracteres
### Pós   condição:
O sistema retorna as oportunidades de trabalho relacionadas a(s) palavra(s) buscadas. Somente o Usuário cadastrado poderá ver os detalhes das oportunidades de trabalho
### Requisitos   relacionados:
UC01, UC02 e UC03  

## UC08 - Gerenciar oportunidades de trabalho 

### Descrição:
Criação de uma oportunidade de trabalho que será publicada no site.
### Atores:
Usuário logado.
### Pré-condição:
O usuário deve estar logado.
### Fluxo Básico:
* O usuário acessa o sistema.
* O usuário clica em "Adicionar nova oportunidade".
* O usuário insere uma descrição para a oportunidade.
* O sistema oferece as opções de nova oportunidade para o usuário.
* O usuário seleciona a tecnologia necessária à candidatura.
* O sistema exibe a janela de envio de oportunidade.
* O usuário seleciona "Publicar oportunidade".
* O sistema carrega a nova oportunidade.

### Fluxo alternativo:
* O usuário tenta criar uma nova oportunidade sem que o status contratando esteja ativado.
    * O sistema não habilita a criação de novas oportunidades.
* Usuário submete a publicação sem preencher a descrição.
    * O sistema identifica que a descrição não foi preenchida.
    * O sistema não submete a publicação.
* Usuário não seleciona uma tecnologia.
    * O sistema não permite o usuário terminar a postagem.
### Regras de validação:
* Status contratando: boleano.
* Descrição: descrição da vaga, máximo de 500 caracteres.
* Tecnologia: texto, máximo 100 caracteres.
### Pós   condição:
A oportunidade de trabalho é publicada e deve ser exibida na categoria Recentes. Um email com aviso da oportunidade é enviado aos perfis DEV com correlação maior que 90% com os parametros da demanda.
### Requisitos   relacionados:
UC01 e UC02.
