
posts
<br/>
<div>
  {% for a in site.posts %}
      <a href='{{site.baseurl}}/{{ a.url }}'>{{ a.title }}</a>
      <br/>
  {% endfor %}
</div>



<hr/>

- [/subfolder/index.md](/subfolder/index.md)
- url: {{ site.url }}
- baseurl:  {{ site.baseurl }}
- markdown: {{ site.markdown }}
- highlighter: {{ site.highlighter }}
- source: {{ site.source }}

<hr/>


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

