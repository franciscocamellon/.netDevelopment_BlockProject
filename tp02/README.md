

<div class="row">
  <div class="column left" style="align:left;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/wiki">1 - Home</a>
  </div>
  <div class="column right" style="align:right;">
    <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/master/tp01#13--requisitos-de-usu%C3%A1rio">3 - Requisitos de usuário</a>
  </div>
</div>

---

## 4 - Requisitos de sistema  

### RS1 - Criar perfil na rede social - Dev/Empresa

| Requisito RS1 | Criar perfil na rede social|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Descrição | Criar um perfil de usuário|
| Ator | Usuário não cadastrado|
| Pré-condição              | O usuário deve possuir um endereço de email, conta no Facebook ou conta no Google+|
| Fluxo Básico              | O usuário acessa o sistema<br>O usuário clica em "Cadastrar"<br>O usuário seleciona fazer cadastro pelo endereço de email<br>O usuário define o tipo de perfil DEV ou EMPRESA<br>O usuário insere o endereço de email que deseja cadastrar<br>O Usuário preenche as informações necessárias para cada perfil DEV ou EMPRESA<br>O Usuário executa a criação do perfil<br> O sistema retorna para a página de perfil|
| Pós   condição            | Um perfil é criado com os dados informados pelo DEV ou EMPRESA|
| Fluxo alternativo         | O usuário se cadastra utilizando sua conta do Facebook<br>O usuário se cadastra utilizando sua conta do Google+<br>O Usuário informa um e-mail que já está associado a algum perfil. Quando executarem a criação do perfil, a mensagem “Esse e-mail já está associado a um perfil” deverá ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | - // - - // -|


### RS2 - Autenticação na rede social

| Requisito RS2 | Autenticação na rede social|
|:---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Descrição | Fazer login em uma conta de usuário já existente|
| Ator | Usuário cadastrado |
| Pré-condição              | O usuário deve possuir um cadastro no site DEVs Network|
| Fluxo Básico              | O usuário acessa o sistema<br>O usuário clica em "Logar"<br>O usuário seleciona fazer login pelo endereço de email<br>O usuário insere o seu endereço de email e sua senha<br>O sistema autentica os dados fornecidos<br>O sistema retorna para a página do perfil|
| Pós   condição            | Após a autenticação o Sistema libera a navegação na rede social e habilita a edição do perfil e criação de posts|
| Fluxo alternativo         | Os Atores digitam um email ou senha que não conferem. Quando isso ocorrer, a mensagem “O {email} não existe em nosso banco de dados.” deverá ser exibida.<br>O usuário se cadastra utilizando sua conta do Facebook<br> O usuário se cadastra utilizando sua conta do Google+ |
| Dados                     | Email: email válido<br>Senha: alfanumérica, mínimo 12 caracteres|
| Requisitos   relacionados | RS1 |

### RS3 - Organizar e gerenciar portifólio - Dev

| Requisito RS3 | Organizar e gerenciar seu portifólio|
|:---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Descrição | Configurar e/ou mudar informações de uma conta|
| Ator | Usuário logado |
| Pré-condição              | O usuário deve estar logado em uma conta DEV ou EMPRESA|
| Fluxo Básico              | O usuário acessa o sistema<br>O usuário clica la logo de sua imagem<br>O usuário clica em "editar"<br>O usuário altera ou não um campos de informações da conta<br>O usuário clica em "salvar edições"<br>O sistema atualiza informações de usuários|
| Pós   condição            | Após a configuração de conta, a pagina é recarregada com as novas informações|
| Fluxo alternativo         | O usuário quer deletar sua conta. <br>O Sistema retorna a mensagem “Tem certeza que quer deletar sua conta?”<br>O Usuário coloca algum dado inválido invalido<br>O sistema verifica o a validez dos campos alterados<br>O sistema aponta que há campos inválidos  |
| Dados                     | Username: Texto, máximo de 100 caracteres.<br>Email: email válido.<br>Projeto: texto, máximo de 100 caracteres.<br>Tecnologia utilizada: lista das tecnologias envolvidas.<br>Aplicativo: link para a loja de aplicativos.|
| Requisitos   relacionados | RS1 e RS2 |

### RS4 - Pesquisar por vaga em aberto

| Requisito RS4 | Pesquisar por vaga em aberto|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Descrição | Buscar um post por meio de uma palavra chave.|
| Atores | Usuário não cadastrado e Usuário cadastrado|
| Pré-condição              | Possuir acesso ao site DEV Network|
| Fluxo Básico              | O usuário não cadastrado ou cadastrado insere o texto no espaço da barra de busca<br>O usuário não cadastrado ou cadastrado escolhe a linguagem de programação na lista de tecnologias<br>O usuário não cadastrado ou cadastrado pressiona a tecla "enter" do teclado ou o botão "buscar"|
| Pós   condição            | O sistema retorna as vagas relacionadas a(s) palavras buscadas|
| Fluxo alternativo         | Nenhuma vaga relacionada com a(s) palavras chave foi encontrada.<br>O Sistema não retorna nenhuma vaga<br>O Sistema retorna a mensagem "Nenhuma vaga foi encontrada para {searchTerm}!"  |
| Dados                     | Termo de busca: texto, máximo de 100 caracteres<br>Tecnologia: texto, máximo 100 caracteres|
| Requisitos   relacionados | RS1 e RS2 |

### RS5 - Receber e enviar mensagens para as empresas - Dev

| Requisito RS5 | Receber e enviar mensagens para as empresas|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Descrição | Buscar um post por meio de uma palavra chave.|
| Ator | DEV |
| Pré-condição              | Possuir um perfil tipo DEV na rede|
| Fluxo Básico              | O Ator deve ter especificado em seu perfil que está disponível para trabalho  <br>O Sistema habilitará seu perfil ser visto em buscas feitas por empresas cadastradas <br>O Ator poderá enviar mensagens para Empresas que lhe contatarem através de mensagens<br> O Ator poderá enviar mensagens para Empresas que estiverem com vagas em aberto|
| Pós   condição            | É gerado um token que habilita a troca de mensagens entre DEV e EMPRESA|
| Fluxo alternativo         | O Ator tenta enviar mensagem para que não tem vagas em aberto. Quando isso ocorrer, a mensagem:<br> “A empresa{nomeDaEmpresa} não está habilitada a receber mensagens”. ou<br>     “A empresa{nomeDaEmpresa} não tem vagas em aberto”.|
| Dados                     | Mensagem: Texto, máximo de 1000 caracteres.<br>Formatação da mensagem: Markdown<br>Anexos: PDF, DOC e ODT, máximo 10Mb.<br>Currículo: HTML gerado automaticamente a partir das informações do portifólio.|
| Requisitos   relacionados | - // - - // -|


### RS8 - Gerenciar oportunidades de trabalho 
| Requisito RS8 | Criar e deletar demanda por profissional|
|---------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Descrição | Buscar um post por meio de uma palavra chave.|
| Ator | Empresa|
| Pré-condição              | Possuir um perfil tipo EMPRESA na rede|
| Fluxo Básico              | O Ator habilita em seu perfil o status contratando<br>O Ator cria uma demanda por profissional<br>O Ator especifica os parametros da demanda<br>O Ator configura o prazo de candidaturas para a demanda<br>O Ator publica a demanda<br>O Ator pausa a demanda<br>O Ator deleta a demanda |
| Pós   condição            | Uma demanda é criada e fica disponível para buscas pelos DEVs. Um email com aviso da vaga é enviado aos perfis DEV com correlação maior que 90% com os parametros da demanda.|
| Fluxo alternativo         | O Ator tenta criar uma demanda sem que o status contratando esteja ativado. Quando isso ocorrer, a mensagem “Status contratando está {hiringStatus}. Não é possível criar uma demanda.”.   Onde {nomeDoCampo} deve ser substituído pelo nome do campo não preenchido.<br>     Exemplos:<br>     “Nome é obrigatório(a)”<br>     “Data de nascimento é obrigatório(a)”<br>O DEV ou a Empresa informa um e-mail que já está associado a algum perfil. Quando a   pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado   a um perfil” deve ser exibida.  |
| Dados                     | Nome: Texto, máximo de 100   caracteres, não pode conter números.<br>Senha: Mais de 8 caracteres.<br>Data de nascimento: Data válida. Permite no mínimo 18 anos.<br>Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos   os dados do tipo texto.<br>Em busca de emprego: checkbox para o DEV marcar sim ou não|
| Requisitos   relacionados | RF2, RF3 (são exemplos aqui)


<table>
  <tr style="text-align:left;width:50%;">
   <td>
      <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/wiki">1 - Home</a>
   </td>
   <td style="text-align:right;width:50%;">
      <a href="https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/master/tp01#13--requisitos-de-usu%C3%A1rio">3 - Requisitos de usuário</a>
   </td>
  </tr>
</table>