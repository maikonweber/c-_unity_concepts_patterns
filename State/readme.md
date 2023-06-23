O padrão State é um padrão de projeto comportamental que permite que um objeto altere seu comportamento quando seu estado interno muda. Ele encapsula diferentes comportamentos em classes separadas e permite a troca dinâmica entre esses comportamentos, conforme o objeto muda de estado. Isso ajuda a evitar a duplicação de código e melhora a flexibilidade e extensibilidade do sistema.

Vamos entender os principais elementos do padrão State:

    Contexto (Context): É a classe que contém o estado interno e define a interface para interagir com os estados. O contexto mantém uma referência para um objeto estado concreto e delega as chamadas de método relacionadas ao estado para esse objeto.

    Estado (State): É a interface ou classe abstrata que define os métodos que representam os diferentes comportamentos relacionados a um estado específico. Cada estado concreto implementa essa interface ou herda da classe abstrata e fornece sua própria implementação para os métodos.

    Estados Concretos (Concrete States): São as classes que implementam a interface ou herdam da classe abstrata do estado. Cada estado concreto define seu próprio comportamento específico relacionado a um estado particular do objeto contexto.

O padrão State é útil quando um objeto precisa alterar seu comportamento com base em diferentes estados, evitando um código complicado e difícil de manter. Ele é especialmente útil quando há uma quantidade significativa de lógica condicional dependente do estado em uma classe.

Vamos ver um exemplo de implementação do padrão State em Unity: