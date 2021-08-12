# add identity

1. add package Microsoft.VisualStudio.Web.CodeGeneration.Design

2. add identity scaffolding no vs 2019
   nome db context sugerido: SocialNetwork.Web.Identity.Data.IdentityDbContext

2. alterar connection string para manter uma única db (negócio e identity)

3. add migration e atualizar bd

4. configurar startup

5. personalizar estilos e html de todas as páginas do identity (

6. decorar controller/actions com [Authorize] ou [AllowAnonymous]

7. alterar links (perfil, logout)

