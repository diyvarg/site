
posts
<br/>
<div>
  {% for a in site.posts %}
      <a href='{{site.baseurl}}/{{ a.url }}'>{{ a.title }}</a>
      <br/>
  {% endfor %}
</div>

<hr />

<script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>



<form id="test-form">
  
  <div>
    <label>Field 1</label>
    <input type="text" name="form_field_1" placeholder="Field 1"/>
  </div>
  
  <div>
    <label>Field 2</label>
    <input type="text" name="form_field_2" placeholder="Field 2"/>
  </div>
  
  <div>
    <label>Field 3 optional</label>
    <input type="text" name="form_field_3" placeholder="Field 3 "/>
  </div>
  
  <div>
    <button type="submit" id="submit-form">Submit</button>
  </div>

</form>


<script>
  var $form = $('form#test-form'),
    url = 'https://script.google.com/macros/s/AKfycbynmmPqfUK-FynNLLK-_jr2guCEi47PaKe9Z0MWd7m9FlFsSiKg/exec'

//alert(1);        

$('#submit-form').on('click', function(e) {
  alert(2 + " data: " + $form.serialize());
  try {
  e.preventDefault();
  var jqxhr = $.ajax({
    url: url,
    method: "GET",
    dataType: "json",
    data: $form.serializeObject()
  });
  } catch(e) { alert("error: " + e); } 
  
  jqxhr.done(function( msg ) {
    alert( "Data Saved: " + JSON.stringify(msg) );
  })
  .fail (function (jqXHR, textStatus, errorThrown) {    alert( "Request failed: " + textStatus + " " +  errorThrown);        });
})
</script> 

<!-- <script src="https://raw.githubusercontent.com/macek/jquery-serialize-object/master/dist/jquery.serialize-object.min.js"></script -->

<script>
  // https://stackoverflow.com/a/5199982
  
  jQuery.fn.serializeObject = function() {
  var arrayData, objectData;
  arrayData = this.serializeArray();
  objectData = {};

  $.each(arrayData, function() {
    var value;

    if (this.value != null) {
      value = this.value;
    } else {
      value = '';
    }

    if (objectData[this.name] != null) {
      if (!objectData[this.name].push) {
        objectData[this.name] = [objectData[this.name]];
      }

      objectData[this.name].push(value);
    } else {
      objectData[this.name] = value;
    }
  });

  return objectData;
};

</script>



<hr/>

- [/subfolder/index.md](/subfolder/index.md)
- url: {{ site.url }}
- baseurl:  {{ site.baseurl }}
- markdown: {{ site.markdown }}
- highlighter: {{ site.highlighter }}
- source: {{ site.source }}
- destination:  {{ site.destination }}         

<hr/>


<iframe src="https://docs.google.com/forms/d/e/1FAIpQLSdNZCQGydEXuoUnpyIWxsFQtD-Z5ftOzVaTD90Gv-WbkmqIyg/viewform?embedded=true" width="640" height="1167" frameborder="0" marginheight="0" marginwidth="0">Загрузка...</iframe>


## Welcome to GitHub Pages

You can use the [editor on GitHub](https://github.com/diyvarg/site/edit/master/README.md) to maintain and preview the content for your website in Markdown files.

Whenever you commit to this repository, GitHub Pages will run [Jekyll](https://jekyllrb.com/) to rebuild the pages in your site, from the content in your Markdown files.

### Markdown

Markdown is a lightweight and easy-to-use syntax for styling your writing. It includes conventions for

```markdown
Syntax highlighted code block

# Header 1
## Header 2
### Header 3

- Bulleted
- List

1. Numbered
2. List

**Bold** and _Italic_ and `Code` text

[Link](url) and ![Image](src)
```
  
``` fsharp
open System.Text.RegularExpressions
let split (by:string) (str:string)  = 
    let rec split (m:Match) = [
        if m.Success then
            let n = m.NextMatch()
            if n.Success = false then yield str.Substring(m.Index).TrimEnd(' ')
            else 
                yield str.Substring(m.Index, n.Index-m.Index).TrimEnd(' ')
                yield! split n ]
    Regex(by).Match str |> split
```

For more details see [GitHub Flavored Markdown](https://guides.github.com/features/mastering-markdown/).

### Jekyll Themes

Your Pages site will use the layout and styles from the Jekyll theme you have selected in your [repository settings](https://github.com/diyvarg/site/settings). The name of this theme is saved in the Jekyll `_config.yml` configuration file.

### Support or Contact

Having trouble with Pages? Check out our [documentation](https://help.github.com/categories/github-pages-basics/) or [contact support](https://github.com/contact) and we’ll help you sort it out.

