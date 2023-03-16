# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Como citado anteriormente, nosso projeto tem foco em desenvolver um sistema que auxilie diversas pessoas e empresas a ter facilidade nas horas de organizar e pagar suas contas sem atraso. Com o intuito de trazer agilidade e simplicidade de informações, e assim, facilitar a vida de pessoas que estão com problemas na hora de se organizar financeiramente. 

## Personas

| Persona                                                                                                            | Informações                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| ------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| ![Foto de Pedro](https://i.pravatar.cc/150?img=33) <br> **Pedro Freire** <br> _Empresário ocupado, 33 anos_        | **História:** Pedro é um empresário que trabalha longas horas todos os dias para administrar sua empresa. Ele geralmente tem pouco tempo livre para si mesmo. <br> **Ocupação:** Proprietário de uma pequena empresa. <br> **Hobbies:** Pedro não tem muito tempo para hobbies, mas gosta de jogar golfe quando pode. <br> **Impedimentos:** Pedro lida com muitas contas e pagamentos em seu trabalho, mas muitas vezes tem dificuldade em acompanhar tudo devido ao seu horário apertado. <br> **Motivações:** Pedro está motivado a encontrar uma maneira mais eficiente de gerenciar suas finanças e contas para economizar tempo e evitar erros. <br> **Frustrações:** Pedro fica frustrado quando perde um pagamento ou não consegue gerenciar suas finanças adequadamente, o que pode afetar negativamente sua empresa. |
| ![Foto de Maria](https://i.pravatar.cc/150?img=31) <br> **Maria Ferreira** <br> _Estudante Universitária, 23 anos_ | **História:** Maria é uma estudante universitária que está se preparando para começar sua carreira. Ela tem um orçamento apertado e está sempre procurando maneiras de economizar dinheiro. <br> **Ocupação:** Estudante universitária. <br> **Hobbies:** Maria gosta de ler, assistir a filmes e sair com amigos. <br> **Impedimentos:** Maria muitas vezes se preocupa com o gerenciamento de seu dinheiro devido a suas despesas com a faculdade e outros custos associados à vida universitária. <br> **Motivações:** Maria está motivada a encontrar maneiras de economizar dinheiro e gerenciar melhor suas finanças para garantir um futuro financeiro mais seguro. <br> **Frustrações:** Maria fica frustrada quando não consegue pagar suas contas a tempo ou quando não consegue manter um orçamento equilibrado.    |
| ![Foto de João](https://i.pravatar.cc/150?img=6) <br> **João Nicácio** <br> _João, o aposentado, 66 anos_          | **História:** Maria é uma estudante universitária que está se preparando para começar sua carreira. Ela tem um orçamento apertado e está sempre procurando maneiras de economizar dinheiro. <br> **Ocupação:** Estudante universitária. <br> **Hobbies:** Maria gosta de ler, assistir a filmes e sair com amigos. <br> **Impedimentos:** Maria muitas vezes se preocupa com o gerenciamento de seu dinheiro devido a suas despesas com a faculdade e outros custos associados à vida universitária. <br> **Motivações:** Maria está motivada a encontrar maneiras de economizar dinheiro e gerenciar melhor suas finanças para garantir um futuro financeiro mais seguro. <br> **Frustrações:** Maria fica frustrada quando não consegue pagar suas contas a tempo ou quando não consegue manter um orçamento equilibrado.    |
| ![Foto de Ana](https://i.pravatar.cc/150?img=16) <br> **Ana Vieira** <br> _Ana, a mãe trabalhadora_                | **História:** Ana é uma mãe solo que trabalha em tempo integral para sustentar sua família. Ela é responsável pelo pagamento de muitas contas e despesas da casa. <br> **Ocupação:** Profissional de marketing em tempo integral. <br> **Hobbies:** Ana não tem muito tempo para hobbies, mas gosta de passar tempo com seus filhos quando pode. <br> **Impedimentos:** A falta de tempo e a sobrecarga de tarefas podem dificultar a administração de todas as suas contas em dia. <br> **Motivações:** Ana deseja ter mais tranquilidade em sua vida diária, ter controle sobre suas finanças e evitar atrasos e multas em suas contas. <br> **Frustrações:** JA falta de organização pode levar a situações estressantes e financeiramente desfavoráveis.                                                                   |

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| EU COMO... `PERSONA` | QUERO/PRECISO ... `FUNCIONALIDADE`                                                       | PARA ... `MOTIVO/VALOR`                                |
| -------------------- | ---------------------------------------------------------------------------------------- | ------------------------------------------------------ |
| Pedro Siqueira       | Adicionar uma nova conta a pagar.                                                        | Manter um registro de todas as minhas contas a pagar.  |
| Pedro Siqueira       | Visualizar contas pendentes de pagamento.                                                | Me organizar financeiramente.                          |
| Maria Ferreira       | Visualizar todas as minhas contas a pagar em uma lista ordenada por data de agendamento. | Ter uma visão geral das minhas obrigações financeiras. |
| Ana Cézamo           | Definir lembretes de pagamento para cada conta a pagar.                                  | Lembrar de pagar as contas e evitar multas e juros.    |
| João Nicácio         | Visualizar todas as minhas contas a pagar em uma lista.                                  | Ter uma visão geral das minhas obrigações financeiras. |
| João Nicácio         | Marcar uma conta como paga assim que efetuar o pagamento.                                | Manter um registro atualizado.                         |

## Modelagem do Processo de Negócio

### Análise da Situação Atual

Apresente aqui os problemas existentes que viabilizam sua proposta. Apresente o modelo do sistema como ele funciona hoje. Caso sua proposta seja inovadora e não existam processos claramente definidos, apresente como as tarefas que o seu sistema pretende implementar são executadas atualmente, mesmo que não se utilize tecnologia computacional.

### Descrição Geral da Proposta

Apresente aqui uma descrição da sua proposta abordando seus limites e suas ligações com as estratégias e objetivos do negócio. Apresente aqui as oportunidades de melhorias.

### Processo 1 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 1. Em seguida, apresente o modelo do processo 1, descrito no padrão BPMN.

![Processo 1](img/02-bpmn-proc1.png)

### Processo 2 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 2. Em seguida, apresente o modelo do processo 2, descrito no padrão BPMN.

![Processo 2](img/02-bpmn-proc2.png)

## Indicadores de Desempenho

Apresente aqui os principais indicadores de desempenho e algumas metas para o processo. Atenção: as informações necessárias para gerar os indicadores devem estar contempladas no diagrama de classe. Colocar no mínimo 5 indicadores.

Usar o seguinte modelo:

![Indicadores de Desempenho](img/02-indic-desemp.png)
Obs.: todas as informações para gerar os indicadores devem estar no diagrama de classe a ser apresentado a posteriori.

## Requisitos

O objetivo estrutural prático do projeto é definido através dos requisitos funcionais que retratam as intenções de comunicação do site com o usuário e disponibilizam as funções esperadas para utilização da ferramenta, tal como os requisitos não funcionais que representam as características técnicas que a equipe deve utilizar na estrutura da montagem do projeto. A seguir serão apresentados os aspectos.nica foi aplicada.

### Requisitos Funcionais

O quadro a seguir exibe os requisitos funcionais da solução, apontando quais são as prioridades que devem ser atendidas:

| ID     | Descrição do Requisito                                                                | Prioridade |
| ------ | ------------------------------------------------------------------------------------- | ---------- |
| RF-001 | A aplicação deve permitir gerenciar agendamentos de contas.                           | ALTA       |
| RF-002 | A aplicação deve permitir gerenciar usuários.                                         | ALTA       |
| RF-003 | O Sistema deve permitir o acesso a contas.                                            | ALTA       |
| RF-004 | O Sistema deve permitir o cadastro de contas.                                         | ALTA       |
| RF-005 | O Sistema deve fornecer ao usuário uma mensagem de confirmação da alteração de senha. | ALTA       |
| RF-006 | O Sistema deve fornecer uma função para marcar contas pagas e contas a pagar.         | ALTA       |
| RF-007 | O Sistema deve fornecer o gerenciamento de contas.                                    | ALTA       |

### Requisitos não Funcionais

O quadro a seguir representam as ferramentas técnicas que devem ser utilizadas no projeto no formato de requisitos não funcionais:

| ID      | Descrição do Requisito                                                                                     | Prioridade |
| ------- | ---------------------------------------------------------------------------------------------------------- | ---------- |
| RNF-001 | O sistema deve ser implementado na linguagem C#, html, CSS e Java Script.                                  | ALTA       |
| RNF-002 | As informações de cadastro do cliente devem ficar disponiveis apenas para os clientes e para a plataforma. | ALTA       |
| RNF-003 | O site deve estar disponível para os principais navegadores: Chrome, Firefox, Edge.                        | ALTA       |
| RNF-004 | O sistemae deve estar disponivel 24hrs por dia, os sete dias da semana                                     | ALTA       |
| RNF-005 | O site deve ser responsivo, compativel a qualquer tipo de aparelho. Ex: Notebook, tablet, celular.         | ALTA       |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.
O andamento desse projeto limita-se por deveres visíveis para a sua conclusão. O quadro a seguir exibi quais são essas limitações.

| ID    | Restrição                                                                                |
| ----- | ---------------------------------------------------------------------------------------- |
| RE-01 | O projeto deve ser entregue ao final do semestre, não ultrapassando o final do semestre. |
| RE-02 | O projeto deve ser desenvolvido em HTML, CSS, JAVA SCRIPT e C#.                          |
| RE-03 | O projeto deve ser realizado pela equipe formada sem interferências externas.            |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
>
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)

# Matriz de Rastreabilidade

A matriz de rastreabilidade é uma ferramenta usada para facilitar a visualização dos relacionamento entre requisitos e outros artefatos ou objetos, permitindo a rastreabilidade entre os requisitos e os objetivos de negócio.

A matriz deve contemplar todos os elementos relevantes que fazem parte do sistema, conforme a figura meramente ilustrativa apresentada a seguir.

![Exemplo de matriz de rastreabilidade](img/02-matriz-rastreabilidade.png)

> **Links Úteis**:
>
> - [Artigo Engenharia de Software 13 - Rastreabilidade](https://www.devmedia.com.br/artigo-engenharia-de-software-13-rastreabilidade/12822/)
> - [Verificação da rastreabilidade de requisitos usando a integração do IBM Rational RequisitePro e do IBM ClearQuest Test Manager](https://developer.ibm.com/br/tutorials/requirementstraceabilityverificationusingrrpandcctm/)
> - [IBM Engineering Lifecycle Optimization – Publishing](https://www.ibm.com/br-pt/products/engineering-lifecycle-optimization/publishing/)

# Gerenciamento de Projeto

De acordo com o PMBoK v6 as dez áreas que constituem os pilares para gerenciar projetos, e que caracterizam a multidisciplinaridade envolvida, são: Integração, Escopo, Cronograma (Tempo), Custos, Qualidade, Recursos, Comunicações, Riscos, Aquisições, Partes Interessadas. Para desenvolver projetos um profissional deve se preocupar em gerenciar todas essas dez áreas. Elas se complementam e se relacionam, de tal forma que não se deve apenas examinar uma área de forma estanque. É preciso considerar, por exemplo, que as áreas de Escopo, Cronograma e Custos estão muito relacionadas. Assim, se eu amplio o escopo de um projeto eu posso afetar seu cronograma e seus custos.

## Gerenciamento de Tempo

Com diagramas bem organizados que permitem gerenciar o tempo nos projetos, o gerente de projetos agenda e coordena tarefas dentro de um projeto para estimar o tempo necessário de conclusão.

![Diagrama de rede simplificado notação francesa (método francês)](img/02-diagrama-rede-simplificado.png)

O gráfico de Gantt ou diagrama de Gantt também é uma ferramenta visual utilizada para controlar e gerenciar o cronograma de atividades de um projeto. Com ele, é possível listar tudo que precisa ser feito para colocar o projeto em prática, dividir em atividades e estimar o tempo necessário para executá-las.

![Gráfico de Gantt](img/02-grafico-gantt.png)

## Gerenciamento de Equipe

O gerenciamento adequado de tarefas contribuirá para que o projeto alcance altos níveis de produtividade. Por isso, é fundamental que ocorra a gestão de tarefas e de pessoas, de modo que os times envolvidos no projeto possam ser facilmente gerenciados.

![Simple Project Timeline](img/02-project-timeline.png)

## Gestão de Orçamento

O processo de determinar o orçamento do projeto é uma tarefa que depende, além dos produtos (saídas) dos processos anteriores do gerenciamento de custos, também de produtos oferecidos por outros processos de gerenciamento, como o escopo e o tempo.

![Orçamento](img/02-orcamento.png)
