# XtraSpellChecker - Getting Started Lesson 2


<p>This example demonstrates how to use the <a href="http://help.devexpress.com/#WindowsForms/clsDevExpressXtraSpellCheckerSpellCheckertopic">SpellChecker</a> component to create a simple application which allows spelling check in German using external German dictionaries.</p>
<p>To create a project, follow the steps of the <a href="http://help.devexpress.com/#WindowsForms/CustomDocument114003">Lesson 2 - Create Simple Application to Check Spelling in MemoEdit</a> tutorial.</p>


<h3>Description</h3>

<p>To start checking the spelling in the <strong>MemoEdit</strong> control on demand, call the <strong>SpellChecker.Check</strong> method with the <strong>MemoEdit</strong> control as a parameter in the button&#39;s <strong>Click</strong> event handler.</p><p>To check the spelling of the <strong>MemoEdit</strong> control as you type, set the <strong>SpellChecker.SpellCheckMode</strong> property to <strong>AsYouType</strong> and call the<strong> spellChecker.Check</strong> method for the<strong> MemoEdit</strong> control, for instance when the form is loading.</p>

<br/>


