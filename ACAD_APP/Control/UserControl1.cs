using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACAD_APP.Control
{
    public partial class <DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=ACAD_APP.Control Type=UserControl1)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="UserControl1" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="UserControl1" SourceLocation="(Assembly=file:///C:/Users/iagoa/Documents/GitHub/TrabUnidade3/ACAD_APP/Control/UserControl1.Designer.cs StartLineNumber=2 StartCharacterOffset=18 EndLineNumber=2 EndCharacterOffset=30)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=ACAD_APP.Control Type=UserControl1)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Classe" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Tipo" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contém" Description="Se a origem do link contém o objeto de destino" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="É Público" Description="Sinalizador para indicar se o escopo é Público" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Ícone" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Rótulo" Description="Rótulo de um objeto Annotatable que pode ser exibido" DataType="System.String" />
    <Property Id="SourceLocation" Label="Número da Linha Inicial" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibilidade" Description="Define se um nó no grafo é visível ou não" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="Arquivo" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Tipo" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/ACAD_APP/ACAD_APP.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/ACAD_APP/Control/UserControl1.Designer.cs" />
    <Alias n="3" Uri="Assembly=$(059d8719-040c-46ed-b9d1-ec8de0316b98.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="059d8719-040c-46ed-b9d1-ec8de0316b98.OutputPathUri" Value="file:///C:/Users/iagoa/Documents/GitHub/TrabUnidade3/ACAD_APP/bin/Debug/net6.0-windows/ACAD_APP.dll" />
    <Path Id="VsSolutionUri" Value="file:///C:/Users/iagoa/Documents/GitHub/TrabUnidade3" />
  </Paths>
</DirectedGraph>UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
    }
}
