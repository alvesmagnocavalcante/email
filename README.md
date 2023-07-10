# email
Enviar E-mail com C#

Este é um aplicativo C# simples que permite enviar e-mails usando o protocolo SMTP.

## Requisitos

- Microsoft .NET Framework 4.7.2 ou superior
- Conta de e-mail configurada com acesso SMTP (como uma conta do Office 365)

## Como usar

1. Clone este repositório em sua máquina local.
2. Abra o projeto em sua IDE preferida que suporte desenvolvimento com C#.
3. Preencha as informações de configuração do servidor SMTP no método `Button1_Click`:
    - `smtpClient.Host`: O host do servidor SMTP (por exemplo, "smtp.office365.com").
    - `smtpClient.Port`: A porta do servidor SMTP (por exemplo, 587).
    - `smtpClient.EnableSsl`: Define se o uso de SSL/TLS está habilitado.
    - `smtpClient.Credentials`: As credenciais de autenticação para o servidor SMTP (e-mail e senha).
4. Compile e execute o projeto.
5. Preencha os campos no formulário:
    - `textBoxDes`: O endereço de e-mail do destinatário.
    - `textBoxTitulo`: O assunto do e-mail.
    - `richTextBoxCorpo`: O corpo do e-mail.
    - `textBoxAnexo`: O nome do arquivo para anexar (opcional).
6. Clique no botão "Enviar" para enviar o e-mail.
7. Uma mensagem de confirmação será exibida se o e-mail for enviado com sucesso.
8. Em caso de erro, uma mensagem de erro será exibida com detalhes.

## Dependências

Não há dependências externas além das bibliotecas padrão do .NET Framework.

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

## Contribuição

Contribuições são bem-vindas! Se você tiver sugestões, correções de bugs ou melhorias, sinta-se à vontade para abrir uma issue ou enviar um pull request.

## Autor

Magno Alves

- GitHub: [MagnoAlves](https://github.com/MagnoAlves)
- LinkedIn: [Magno Alves](https://www.linkedin.com/in/magno-alves-712b6624b/)


