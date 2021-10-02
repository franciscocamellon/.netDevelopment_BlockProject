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
<h4 align="center" padding-top="200"> TP03 - Projeto de Bloco</h4>
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
### [Introdução](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#introdu%C3%A7%C3%A3o-1)

* [Propósito](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#prop%C3%B3sito)
* [Escopo do projeto](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#escopo-do-projeto)
### [Descrição do sistema](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#descri%C3%A7%C3%A3o-do-sistema-1)
### [Requisitos de usuário e de sistema](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#requisitos-de-usu%C3%A1rio-e-de-sistema-1)
* [Requisitos de usuário](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#requisitos-de-usu%C3%A1rio)
* [Requisitos de sistema - Casos de Uso](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#requisitos-de-sistema)
* [Matriz de rastreabilidade](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/README.md#matriz-de-rastreabilidade)
### [Diagramas UML](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp05/tp05#diagramas-uml-1)
* [Diagrama de Classe](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp05/tp05#diagrama-de-classe)
* [Diagrama de Componente](https://github.com/franciscocamellon/.netDevelopment_BlockProject/tree/tp05/tp05#diagrama-de-componente)
### [Relatório](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/master/at/README.md#relat%C3%B3rio-1)
* [Modelo de desenvolvimento em cascata](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/master/at/README.md#modelo-de-desenvolvimento-em-cascata)
* [Etapas do modelo em cascata](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/master/at/README.md#etapas-do-modelo-em-cascata)
* [Considerações](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/master/at/README.md#etapas-do-modelo-em-cascata)

<p><br></p>

---

<p><br></p>

# Introdução  

* ## Propósito  
	Este documento tem por objetivo especificar as funcionalidades necessárias para o desenvolvimento do produto. Fornecer as informações para realizar estimativas. Definir as restrições sobre uso de tecnologias e ferramentas. Fornecer os detalhes necessários para o desenvolvimento de funcionalidades e criação de diagramas como documento. Assegurar que as funcionalidades aqui descritas farão parte do entregável ao final do projeto. Assegurar a passagem de conhecimento de maneira objetiva e descritiva sobre as necessidades do produto.

* ## Escopo do projeto
	Criar uma rede social para desenvolvedores de aplicativos mobile. O objetivo é oferecer um local unificado, onde os desenvolvedores poderão expor seus trabalhos em um portifólio pessoal onde empresas interessadas poderão buscar os profissionais utilizando-se de alguns filtros. Com esta rede social, os desenvolvedores também poderão organizar fóruns de debate sobre tecnologia e podcasts. O objetivo inicial é conectar esses desenvolvedores às empresas que buscam profissionais, e, fazer da rede o espaço onde expõe seus portifólios.
# Descrição do sistema
* O sistema deve permitir aos usuários que criem perfis do tipo DEV e EMPRESA;
    * Perfis do tipo DEV devem conter informações do desenvolvedor como por exemplo, tecnologias mais utilizadas, participação em projetos, aplicativos desenvolvidos, mídias de seus aplicativos e projetos, bem como se está aberto para trabalho.
    * Perfis do tipo EMPRESA devem conter informações sobre a empresa contratante tipo, nome, localização, tipo de oportunidade que oferece, tecnologia necessária, entre outras.
* O sistema deve permitir aos usuários o gerenciamento total de seus perfis bem como sua deleção;
* O sistema deve permitir a troca de mensagens entre os perfis, webconferências e a criação de posts categorizados por assunto. 

# Requisitos de Usuário e de Sistema
* ## Requisitos de Usuário
	*  ### R01 - Criar perfil na rede social  
		O perfil é a parte primária dessa rede social. Aqui serão requisitadas informações cadastrais de contato e de tipo de usuário (Dev ou Empresa).  
	* ### R02 - Autenticação na rede social
		A autenticação no sistema deve prover segurança e interoperabilidade com outros meio de autenticação como Facebook e Google+.
	*  ### R03 - Gerenciar portifólio
		O portifólio é a parte fundamental desta rede social. É através dele que as empresas farão suas buscas pela rede social. Deve conter informações relevantes como projetos realizados, links para Github, Fiverr, Upwork, entre outros.
	*  ### R04 - Pesquisar por oportunidade de trabalho
		O usuário deverá ter seu perfil/portifólio exibido às empresas como resultado da busca das mesmas no mecanismo de busca do sistema.
	*  ### R05 - Criar currículo atrelado ao portifólio
		O currículo será um documento privado gerado automaticamente pelo sistema com base em seus dados cadastrais e seu portifólio. É o documento formal mais detalhado que será enviado à empresa interessada.
	*  ### R06 - Criar posts categorizados
		O usuário deverá ser capaz de criar e publicar posts em diferentes categorias.
	*  ### R07 - Compartilha currículo para as empresas
		O usuário deverá ser capaz de compartilhar seu currículo com as empresas interessadas.
	*  ### R08 - Gerenciar oportunidades de trabalho 
		A empresa deverá criar e deletar oportunidades de emprego dentro do sistema.
	*  ### R09 - Criar processos seletivos
		A Empresa deverá ser capaz de criar e organizar processos de entrevistas pelo sistema.
	*  ###	R10 - Contatar o desenvolvedor via web conferencia
		A Empresa deverá ser capaz de contatar o Dev selecionado para entrevista através do sistema.  

* ## Requisitos de Sistema
	*  ###	 UC01 - Criar perfil na rede social

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


	*  ###	 UC02 - Autenticação na rede social

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

	*  ###	 UC03 - Gerenciar portifólio


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

	*  ###	 UC04 - Pesquisar por oportunidade de trabalho

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

	*  ###	 UC08 - Gerenciar oportunidades de trabalho 

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

# Matriz de Rastreabilidade  

* ## Matriz de Rastreabilidade - DEVs Network  

	|Requisito|UC01|UC02|UC03|UC04|UC08|
	|:-------:|:-------:|:-------:|:-------:|:-------:|:-------:|
	UC01||||||
	UC02|X|||||
	UC03|X|X||||
	UC04|X|X|X|||
	UC08|X|X||||

* ## Matriz de Rastreabilidade dos Requisitos - DEVs Network  

	|Código|Prioridade|Descrição|Tipo|Status|
	|:-------:|:-------:|:-------|:-------:|:-------|
	UC01|Altíssima|Criar um perfil de usuário.|Técnico|Em andamento|
	UC02|Altíssima|Fazer login em uma conta de usuário já existente.|Técnico|Em andamento|
	UC03|Alta|Configurar e/ou mudar informações de uma conta.|Técnico|Pendente|
	UC04|Alta|Buscar uma oportunidade de trabalho por meio de uma palavra chave.|Técnico|Pendente|
	UC08|Alta|Criação de uma oportunidade de trabalho que será publicada no site.|Técnico|Pendente|  

# Diagramas UML

* ## Diagrama de Classe  
![Diagrama de classe UML](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/Diagrama%20de%20classe%20UML.svg)

* ## Diagrama de Componente  
![Diagrama de componente UML](https://github.com/franciscocamellon/.netDevelopment_BlockProject/blob/tp05/tp05/Diagrama%20de%20sequ%C3%AAncia%20uml.svg)

# Relatório

* ## Modelo de desenvolvimento em cascata  

O modelo de desenvolvimento de software em cascata é mais antigo e estabelecido do que as metodologias de desenvolvimento ágil. Em poucas palavras, ele envolve a criação de ferramentas a partir de etapas bem definidas, como:

* análise;
* projeto;
* teste;
* codificação;
* implementação;
* manutenção.

É conhecido por ter uma estrutura mais engessada, com poucas aberturas para mudanças no meio do caminho.

* ## Etapas do modelo em cascata

* Levantamento de requisitos
    * etapa na qual levanta-se os requisitos a partir da interação com o usuário para entender suas demandas e funcionalidades do sistema. Aqui observa-se o objetivo do sistema
(classificados de emprego), a definição do seu escopo (gerencial) e suas limitações, que neste caso pelo fato do usuário ser o próprio desenvolvedor não foi dado a devida atenção.  
* Análilse e projeto
    * aqui foram realizados o desenvolvimento de diagramas de classe e componentes a fim de aumentar o detalhamento e fazer um desenho inicial da solução. Foram feitos também bancos de dados com o objetivo de analisar o relacionamento entre entidades.
* Implantação
    * foram implementados alguns dos requisitos de sistema desenvolvidos  
    
* ## Considerações  

    Nem sempre garante uma produção simples devido ao fato de não admitir mudanças ao longo do projeto, sendo mais adequado para projetos com escopos e requisitos rigorosamente definidos. Mudanças de escopo são lentas e demandam um processo formal de gestão de mudanças.
