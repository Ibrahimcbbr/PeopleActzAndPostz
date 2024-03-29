﻿namespace PeopleActzAndPostz.Domain.Common.Constants
{
    public static class EmailTemplates
    {
        public static Dictionary<string, string> PasswordReset(string email, string token) => new()
    {
        { "Title" , "Password Reset" },
        { "Body" , "Hi. To reset your password please click to button below." },
        { "Link", $"https://localhost:7250/api/auth/ResetPassword?email={email}&token={token}" },
        { "Button","Reset Password" }
    };
        public static Dictionary<string, string> AccountActivation(string email, string token) => new()
    {
        { "Title" , "Account Activation" },
        { "Body" , "Hi. Welcome to PeopleActzAndPostz, to activate your account, just click the button below." },
        { "Link", $"https://localhost:7250/api/auth/ConfirmMail?email={email}&token={token}" },
        { "Button","Activate Account" }
    };
        public static string EmailMessage(Dictionary<string, string> values) => $@"
<!DOCTYPE html>
<html lang='en' xmlns='http://www.w3.org/1999/xhtml' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:o='urn:schemas-microsoft-com:office:office'>
<head>
  <title> Notificatin [QuizApp] </title>
  <meta http-equiv='X-UA-Compatible' content='IE=edge'>
  <meta http-equiv='Content-Type' content='text/html; charset=UTF-8'>
  <meta name='viewport' content='width=device-width, initial-scale=1'>
  <style type='text/css'>
    #outlook a {{
      padding: 0;
    }}
    body {{
      margin: 0;
      padding: 0;
      -webkit-text-size-adjust: 100%;
      -ms-text-size-adjust: 100%;
    }}
    table,
    td {{
      border-collapse: collapse;
      mso-table-lspace: 0pt;
      mso-table-rspace: 0pt;
    }}
    img {{
      border: 0;
      height: auto;
      line-height: 100%;
      outline: none;
      text-decoration: none;
      -ms-interpolation-mode: bicubic;
    }}
    p {{
      display: block;
      margin: 13px 0;
    }}
  </style>
  <link href='https://fonts.googleapis.com/css?family=Roboto:100,300,400,700' rel='stylesheet' type='text/css'>
  <style type='text/css'>
    @import url(https://fonts.googleapis.com/css?family=Roboto:100,300,400,700);
  </style>
  <style type='text/css'>
    @media only screen and (min-width:480px) {{
      .mj-column-per- 100 {{
        width: 100% !important;
        max-width: 100%;
      }}
    }}
  </style>
  <style type='text/css'>
    @media only screen and (max-width:480px) {{
      table.mj-full-width- mobile {{
        width: 100% !important;
      }}
      td.mj-full-width-mobile {{
        width: auto !important;
      }}
    }}
  </style>
  <style type='text/css'>
    a,
    span,
    td,
    th {{
      -webkit-font-smoothing: antialiased !important;
      -moz-osx-font-smoothing: grayscale !important;
    }}
  </style>
<style>body {{
margin: 0; padding: 0; -webkit-text-size-adjust: 100%; -ms-text-size-adjust: 100%;
}}
img {{
border: 0; height: auto; line-height: 100%; outline: none; text-decoration: none; -ms-interpolation-mode: bicubic;
}}
</style>
</head>
<body style='-webkit-text-size-adjust: 100%; -ms-text-size-adjust: 100%; margin: 0; padding: 0;' bgcolor='#f3f3f5'>
  <div style='display: none; font-size: 1px; color: #ffffff; line-height: 1px; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;'></div>
  <div style='background-color: #f3f3f5;'>
    <div style='max-width: 600px; margin: 0px auto;'>
      <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width: 100%; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;'>
        <tbody>
          <tr>
            <td style='direction: ltr; font-size: 0px; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 20px 0;' align='center'>
              <div class='mj-column-per-100 mj-outlook-group-fix' style='font-size: 0px; direction: ltr; display: inline-block; vertical-align: top; width: 100%;' align='left'>
                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align: top; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;' width='100%'>
                  <tr>
                    <td style='font-size: 0px; word-break: break-word; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important;'>
                      <div style='height: 20px;'></div>
                    </td>
                  </tr>
                </table>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
    <div style='background: #54595f; background-color: #54595f; border-radius: 4px 4px 0 0; max-width: 600px; margin: 0px auto;'>
      <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background: #54595f; width: 100%; border-radius: 4px 4px 0 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;' bgcolor='#54595f'>
        <tbody>
          <tr>
            <td style='direction: ltr; font-size: 0px; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 20px 0;' align='center'>
              <div style='max-width: 600px; margin: 0px auto;'>
                <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width: 100%; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;'>
                  <tbody>
                    <tr>
                      <td style='direction: ltr; font-size: 0px; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 0px;' align='center'>
                        <div class='mj-column-per-100 mj-outlook-group-fix' style='font-size: 0px; direction: ltr; display: inline-block; vertical-align: top; width: 100%;' align='left'>
                          <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align: top; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;' width='100%'>
                            <tr>
                              <td align='center' style='font-size: 0px; word-break: break-word; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 10px 25px;'>
                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse: collapse; border-spacing: 0px; mso-table-lspace: 0pt; mso-table-rspace: 0pt;'>
                                  <tbody>
                                    <tr>
                                      <td style='width: 150px; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important;'>
																<div style='font-family: Roboto, Helvetica, Arial, sans-serif; font-size: 24px; font-weight: 400; line-height: 30px; color: #ffffff;' align='center'>
                                  <h1 style='font-size: 34px; line-height: normal; font-weight: 400; margin: 0;'>QuizApp</h1>
                                </div>
                                      </td>
                                    </tr>
                                  </tbody>
                                </table>
                              </td>
                            </tr>
                            <tr>
                              <td style='font-size: 0px; word-break: break-word; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important;'>
                                <div style='height: 20px;'></div>
                              </td>
                            </tr>
                            <tr>
                              <td align='center' style='font-size: 0px; word-break: break-word; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 10px 25px;'>
                                <div style='font-family: Roboto, Helvetica, Arial, sans-serif; font-size: 24px; font-weight: 400; line-height: 30px; color: #ffffff;' align='center'>
                                  <h1 style='font-size: 24px; line-height: normal; font-weight: 400; margin: 0;'>{values.GetValueOrDefault("Title")}</h1>
                                </div>
                              </td>
                            </tr>
                            <tr>
                              <td align='left' style='font-size: 0px; word-break: break-word; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 10px 25px;'>
                                <div style='font-family: Roboto, Helvetica, Arial, sans-serif; font-size: 14px; font-weight: 400; line-height: 20px; color: #ffffff;' align='center'>
                                  <p style='display: block; margin: 0;'>{values.GetValueOrDefault("Body")}</p>
                                </div>
                              </td>
                            </tr>
                            <tr>
                              <td align='center' vertical-align='middle' style='font-size: 0px; word-break: break-word; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 10px 25px;'>
                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse: separate; line-height: 100%; mso-table-lspace: 0pt; mso-table-rspace: 0pt;'>
                                  <tr>
                                    <td align='center' bgcolor='#2e58ff' role='presentation' style='border-radius: 3px; cursor: auto; mso-padding-alt: 10px 25px; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; border-style: none;' valign='middle'>
                                      <a href='{values.GetValueOrDefault("Link")}' style='display: inline-block; background-color: #2e58ff; color: white; font-family: Roboto, Helvetica, Arial, sans-serif; font-size: 14px; font-weight: normal; line-height: 32px; text-decoration: none; text-transform: none; mso-padding-alt: 0px; border-radius: 10px; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; margin: 0; padding: 10px 25px;' target='_blank'>
                                        <strong>{values.GetValueOrDefault("Button")}</strong>
                                      </a>
                                    </td>
                                  </tr>
                                </table>
                              </td>
                            </tr>
                          </table>
                        </div>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </div>
              <div style='max-width: 600px; margin: 0px auto;'>
                <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width: 100%; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;'>
                  <tbody>
                    <tr>
                      <td style='direction: ltr; font-size: 0px; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 20px 0;' align='center'>
                        <div class='mj-column-per-100 mj-outlook-group-fix' style='font-size: 0px; direction: ltr; display: inline-block; vertical-align: top; width: 100%;' align='left'>
                          <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align: top; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;' width='100%'>
                            <tr>
                              <td align='left' style='font-size: 0px; word-break: break-word; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; -webkit-font-smoothing: antialiased !important; -moz-osx-font-smoothing: grayscale !important; padding: 10px 25px;'>
                                <div style='font-family: Roboto, Helvetica, Arial, sans-serif; font-size: 10px; font-weight: 400; line-height: 20px; color: #ffffff;' align='left'>
                                  <p style='display: block; margin: 0;'>If you didn't request this mail, please ignore it</p>
                                </div>
                              </td>
                            </tr>
                          </table>
                        </div>
                      </td>
                    </tr>
                  </tbody>
                </table>
              </div>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</body>
</html>
";
    }
}

