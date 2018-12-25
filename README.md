# Descrição do projeto
  
  Foi desenvolvido um CRUD de Filmes, Cidades, Cinemas, Salas e Sessões em ASP.NET
  CORE MVC usando RAZOR no front-end. Portanto, é possível cadastrar, visualizar,
  editar e deletar esses itens, sendo que a cidade só é criada no momento que o
  endereço do cinema é cadastrado ou editado. O endereço pode ser preenchido
  automaticamente ao digitar o CEP, pois será utilizado uma API para consultar os dados.

# Configurações para rodar o projeto
  
  O projeto está usando uma base de dados em um servidor do site SmarterASP.NET,
  portanto NÃO É NECESSÁRIO criar banco de dados em ambiente local para rodar o projeto.
  
  No entanto, também é possível criar a base local. Para isso, basta executar o script de
  criação do banco que está no Github e configurar a connection String que está na
  classe IngressoWebContext.

