



<!DOCTYPE html>
<html lang="en" class="   ">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>SuperMeatyController2D/CharacterController2D.cs at master · Mimerme/SuperMeatyController2D</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="Mimerme/SuperMeatyController2D" name="twitter:title" /><meta content="Contribute to SuperMeatyController2D development by creating an account on GitHub." name="twitter:description" /><meta content="https://avatars1.githubusercontent.com/u/6308253?v=2&amp;s=400" name="twitter:image:src" />
<meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars1.githubusercontent.com/u/6308253?v=2&amp;s=400" property="og:image" /><meta content="Mimerme/SuperMeatyController2D" property="og:title" /><meta content="https://github.com/Mimerme/SuperMeatyController2D" property="og:url" /><meta content="Contribute to SuperMeatyController2D development by creating an account on GitHub." property="og:description" />

    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="conduit-xhr" href="https://ghconduit.com:25035">
    <link rel="xhr-socket" href="/_sockets">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="182C098B:7B5B:2D6418F:53EAC664" name="octolytics-dimension-request_id" /><meta content="6308253" name="octolytics-actor-id" /><meta content="Mimerme" name="octolytics-actor-login" /><meta content="5f945a77e19c06974bdd2404a97c3b8ed64c8f84ac0a4065b4a2ab0daafe4692" name="octolytics-actor-hash" />
    

    
    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="0HzCj2h+5kSGOv5HeBuxymiumFAYbU2B/JOZkJXVYWtvtu2AR98hM9+oH4HKbkIU2orJB/xyyl1vTYLTwN/ZPg==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-013db558b75ed8e45b8a7ccd0caca4ad57c6f1ac.css" media="all" rel="stylesheet" type="text/css" />
    <link href="https://assets-cdn.github.com/assets/github2-c9b5fd6520f5ab77dd823b1b2c81ff9c461b1374.css" media="all" rel="stylesheet" type="text/css" />
    


    <meta http-equiv="x-pjax-version" content="02b35f5d8a0eef0fb5eae58978690905">

      
  <meta name="description" content="Contribute to SuperMeatyController2D development by creating an account on GitHub.">


  <meta content="6308253" name="octolytics-dimension-user_id" /><meta content="Mimerme" name="octolytics-dimension-user_login" /><meta content="18657215" name="octolytics-dimension-repository_id" /><meta content="Mimerme/SuperMeatyController2D" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="18657215" name="octolytics-dimension-repository_network_root_id" /><meta content="Mimerme/SuperMeatyController2D" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/Mimerme/SuperMeatyController2D/commits/master.atom" rel="alternate" title="Recent Commits to SuperMeatyController2D:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      
      


      <div class="header header-logged-in true">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" aria-label="Homepage">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


        <a href="/notifications" aria-label="You have no unread notifications" class="notification-indicator tooltipped tooltipped-s" data-hotkey="g n">
        <span class="mail-status all-read"></span>
</a>

      <div class="command-bar js-command-bar  in-repository">
          <form accept-charset="UTF-8" action="/search" class="command-bar-form" id="top_search_form" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>

<div class="commandbar">
  <span class="message"></span>
  <input type="text" data-hotkey="s, /" name="q" id="js-command-bar-field" placeholder="Search or type a command" tabindex="1" autocapitalize="off"
    
    data-username="Mimerme"
    data-repo="Mimerme/SuperMeatyController2D"
  >
  <div class="display hidden"></div>
</div>

    <input type="hidden" name="nwo" value="Mimerme/SuperMeatyController2D">

    <div class="select-menu js-menu-container js-select-menu search-context-select-menu">
      <span class="minibutton select-menu-button js-menu-target" role="button" aria-haspopup="true">
        <span class="js-select-button">This repository</span>
      </span>

      <div class="select-menu-modal-holder js-menu-content js-navigation-container" aria-hidden="true">
        <div class="select-menu-modal">

          <div class="select-menu-item js-navigation-item js-this-repository-navigation-item selected">
            <span class="select-menu-item-icon octicon octicon-check"></span>
            <input type="radio" class="js-search-this-repository" name="search_target" value="repository" checked="checked">
            <div class="select-menu-item-text js-select-button-text">This repository</div>
          </div> <!-- /.select-menu-item -->

          <div class="select-menu-item js-navigation-item js-all-repositories-navigation-item">
            <span class="select-menu-item-icon octicon octicon-check"></span>
            <input type="radio" name="search_target" value="global">
            <div class="select-menu-item-text js-select-button-text">All repositories</div>
          </div> <!-- /.select-menu-item -->

        </div>
      </div>
    </div>

  <span class="help tooltipped tooltipped-s" aria-label="Show command bar help">
    <span class="octicon octicon-question"></span>
  </span>


  <input type="hidden" name="ref" value="cmdform">

</form>
        <ul class="top-nav">
          <li class="explore"><a href="/explore">Explore</a></li>
            <li><a href="https://gist.github.com">Gist</a></li>
            <li><a href="/blog">Blog</a></li>
          <li><a href="https://help.github.com">Help</a></li>
        </ul>
      </div>

    
<ul id="user-links">
  <li>
    <a href="/Mimerme" class="name">
      <img alt="Mimerme" data-user="6308253" height="20" src="https://avatars0.githubusercontent.com/u/6308253?v=2&amp;s=40" width="20" /> Mimerme
    </a>
  </li>

  <li class="new-menu dropdown-toggle js-menu-container">
    <a href="#" class="js-menu-target tooltipped tooltipped-s" aria-label="Create new...">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-arrow"></span>
    </a>

    <div class="new-menu-content js-menu-content">
    </div>
  </li>

  <li>
    <a href="/settings/profile" id="account_settings"
      class="tooltipped tooltipped-s"
      aria-label="Account settings ">
      <span class="octicon octicon-tools"></span>
    </a>
  </li>
  <li>
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="ZD4XYhx+3+FkRZAsYEG97QCpjyaMJF+ueje8B26RUM4EeYMxlabhlJtgriAcKMV676MFCnYodmNweqtlZYAv9A==" /></div>
      <button class="sign-out-button tooltipped tooltipped-s" aria-label="Sign out">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>

<div class="js-new-dropdown-contents hidden">
  
<ul class="dropdown-menu">
  <li>
    <a href="/new"><span class="octicon octicon-repo"></span> New repository</a>
  </li>
  <li>
    <a href="https://porter.github.com/new"><span class="octicon octicon-move-right"></span> Import repository</a>
  </li>
  <li>
    <a href="/organizations/new"><span class="octicon octicon-organization"></span> New organization</a>
  </li>


    <li class="section-title">
      <span title="Mimerme/SuperMeatyController2D">This repository</span>
    </li>
      <li>
        <a href="/Mimerme/SuperMeatyController2D/issues/new"><span class="octicon octicon-issue-opened"></span> New issue</a>
      </li>
      <li>
        <a href="/Mimerme/SuperMeatyController2D/settings/collaboration"><span class="octicon octicon-person"></span> New collaborator</a>
      </li>
</ul>

</div>


    
  </div>
</div>

      

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

    <li class="subscription">
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="XcKw+KdfYbvUTmEJhG4O87p6ryaGWGn0+jSxVjrQ+omuPckcxDOHK74ladAUBRob90zYI+5LmtREINWEo0hUyg==" /></div>  <input id="repository_id" name="repository_id" type="hidden" value="18657215" />

    <div class="select-menu js-menu-container js-select-menu">
      <a class="social-count js-social-count" href="/Mimerme/SuperMeatyController2D/watchers">
        3
      </a>
      <a href="/Mimerme/SuperMeatyController2D/subscription"
        class="minibutton select-menu-button with-count js-menu-target" role="button" tabindex="0" aria-haspopup="true">
        <span class="js-select-button">
          <span class="octicon octicon-eye"></span>
          Unwatch
        </span>
      </a>

      <div class="select-menu-modal-holder">
        <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
          <div class="select-menu-header">
            <span class="select-menu-title">Notifications</span>
            <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
          </div> <!-- /.select-menu-header -->

          <div class="select-menu-list js-navigation-container" role="menu">

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_included" name="do" type="radio" value="included" />
                <h4>Not watching</h4>
                <span class="description">Be notified when participating or @mentioned.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Watch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input checked="checked" id="do_subscribed" name="do" type="radio" value="subscribed" />
                <h4>Watching</h4>
                <span class="description">Be notified of all conversations.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-eye"></span>
                  Unwatch
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

            <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <div class="select-menu-item-text">
                <input id="do_ignore" name="do" type="radio" value="ignore" />
                <h4>Ignoring</h4>
                <span class="description">Never be notified.</span>
                <span class="js-select-button-text hidden-select-button-text">
                  <span class="octicon octicon-mute"></span>
                  Stop ignoring
                </span>
              </div>
            </div> <!-- /.select-menu-item -->

          </div> <!-- /.select-menu-list -->

        </div> <!-- /.select-menu-modal -->
      </div> <!-- /.select-menu-modal-holder -->
    </div> <!-- /.select-menu -->

</form>
    </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/Mimerme/SuperMeatyController2D/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="X0KOt8c7d3X/y7ofZ2M/Hji2/Xk5OBFG7quBUJ7antAs4UbIrPixOCl89aw7/TsrsLVzn9u8ZP79ht9oO/Jrqg==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Unstar this repository" title="Unstar Mimerme/SuperMeatyController2D">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/Mimerme/SuperMeatyController2D/stargazers">
          9
        </a>
</form>
    <form accept-charset="UTF-8" action="/Mimerme/SuperMeatyController2D/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="2z/ndCLnD0hKLZgqegYUB1hJiPyhKikKVfWqB1rVdsQpxE4Ow0f9b77Skh/8FWDzuBnFSLx/Xz/PBbBayZwupA==" /></div>
      <button
        class="minibutton with-count js-toggler-target star-button"
        aria-label="Star this repository" title="Star Mimerme/SuperMeatyController2D">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/Mimerme/SuperMeatyController2D/stargazers">
          9
        </a>
</form>  </div>

  </li>


        <li>
          <a href="/Mimerme/SuperMeatyController2D/fork" class="minibutton with-count js-toggler-target fork-button lighter tooltipped-n" title="Fork your own copy of Mimerme/SuperMeatyController2D to your account" aria-label="Fork your own copy of Mimerme/SuperMeatyController2D to your account" rel="nofollow" data-method="post">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/Mimerme/SuperMeatyController2D/network" class="social-count">1</a>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/Mimerme" class="url fn" itemprop="url" rel="author"><span itemprop="title">Mimerme</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/Mimerme/SuperMeatyController2D" class="js-current-repository js-repo-home-link">SuperMeatyController2D</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<div class="sunken-menu vertical-right repo-nav js-repo-nav js-repository-container-pjax js-octicon-loaders" data-issue-count-url="/Mimerme/SuperMeatyController2D/issues/counts">
  <div class="sunken-menu-contents">
    <ul class="sunken-menu-group">
      <li class="tooltipped tooltipped-w" aria-label="Code">
        <a href="/Mimerme/SuperMeatyController2D" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-pjax="true" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /Mimerme/SuperMeatyController2D">
          <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

        <li class="tooltipped tooltipped-w" aria-label="Issues">
          <a href="/Mimerme/SuperMeatyController2D/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /Mimerme/SuperMeatyController2D/issues">
            <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
            <span class="js-issue-replace-counter"></span>
            <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>        </li>

      <li class="tooltipped tooltipped-w" aria-label="Pull Requests">
        <a href="/Mimerme/SuperMeatyController2D/pulls" aria-label="Pull Requests" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g p" data-selected-links="repo_pulls /Mimerme/SuperMeatyController2D/pulls">
            <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull Requests</span>
            <span class="js-pull-replace-counter"></span>
            <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>


        <li class="tooltipped tooltipped-w" aria-label="Wiki">
          <a href="/Mimerme/SuperMeatyController2D/wiki" aria-label="Wiki" class="js-selected-navigation-item sunken-menu-item js-disable-pjax" data-hotkey="g w" data-selected-links="repo_wiki /Mimerme/SuperMeatyController2D/wiki">
            <span class="octicon octicon-book"></span> <span class="full-word">Wiki</span>
            <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>        </li>
    </ul>
    <div class="sunken-menu-separator"></div>
    <ul class="sunken-menu-group">

      <li class="tooltipped tooltipped-w" aria-label="Pulse">
        <a href="/Mimerme/SuperMeatyController2D/pulse/weekly" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="pulse /Mimerme/SuperMeatyController2D/pulse/weekly">
          <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>

      <li class="tooltipped tooltipped-w" aria-label="Graphs">
        <a href="/Mimerme/SuperMeatyController2D/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="repo_graphs repo_contributors /Mimerme/SuperMeatyController2D/graphs">
          <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>      </li>
    </ul>


      <div class="sunken-menu-separator"></div>
      <ul class="sunken-menu-group">
        <li class="tooltipped tooltipped-w" aria-label="Settings">
          <a href="/Mimerme/SuperMeatyController2D/settings" aria-label="Settings" class="js-selected-navigation-item sunken-menu-item" data-pjax="true" data-selected-links="repo_settings /Mimerme/SuperMeatyController2D/settings">
            <span class="octicon octicon-tools"></span> <span class="full-word">Settings</span>
            <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/images/spinners/octocat-spinner-32.gif" width="16" />
</a>        </li>
      </ul>
  </div>
</div>

              <div class="only-with-full-nav">
                
  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=push">
  <h3><strong>HTTPS</strong> clone URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="https://github.com/Mimerme/SuperMeatyController2D.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="https://github.com/Mimerme/SuperMeatyController2D.git" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=push">
  <h3><strong>SSH</strong> clone URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="git@github.com:Mimerme/SuperMeatyController2D.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="git@github.com:Mimerme/SuperMeatyController2D.git" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=push">
  <h3><strong>Subversion</strong> checkout URL</h3>
  <div class="input-group">
    <input type="text" class="input-mini input-monospace js-url-field"
           value="https://github.com/Mimerme/SuperMeatyController2D" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard minibutton zeroclipboard-button" data-clipboard-text="https://github.com/Mimerme/SuperMeatyController2D" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>


<p class="clone-options">You can clone with
      <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>,
      <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>,
      or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/Mimerme/SuperMeatyController2D" class="minibutton sidebar-button" title="Save Mimerme/SuperMeatyController2D to your computer and use it in GitHub Desktop." aria-label="Save Mimerme/SuperMeatyController2D to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>

                <a href="/Mimerme/SuperMeatyController2D/archive/master.zip"
                   class="minibutton sidebar-button"
                   aria-label="Download Mimerme/SuperMeatyController2D as a zip file"
                   title="Download Mimerme/SuperMeatyController2D as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/Mimerme/SuperMeatyController2D/blob/f299d8a30b2fe62048c8a6e82143239d209efef5/Assets/CharacterController2D.cs" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:06d0871ab62b378da0ce78172460e9de -->

<div class="file-navigation">
  
<div class="select-menu js-menu-container js-select-menu" >
  <span class="minibutton select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div> <!-- /.select-menu-header -->

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Find or create a branch…" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Find or create a branch…">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div><!-- /.select-menu-tabs -->
      </div><!-- /.select-menu-filters -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <div class="select-menu-item js-navigation-item selected">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <a href="/Mimerme/SuperMeatyController2D/blob/master/Assets/CharacterController2D.cs"
                 data-name="master"
                 data-skip-pjax="true"
                 rel="nofollow"
                 class="js-navigation-open select-menu-item-text css-truncate-target"
                 title="master">master</a>
            </div> <!-- /.select-menu-item -->
        </div>

          <form accept-charset="UTF-8" action="/Mimerme/SuperMeatyController2D/branches" class="js-create-branch select-menu-item select-menu-new-item-form js-navigation-item js-new-item-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="Hzf7ZnqwanmMbM7TDGhphpPDnPefcGd9KfkcR7lFxMWE+tdgZ25HGdemxddpMf9wRkADMOqgsY1TTygYyJZV5g==" /></div>
            <span class="octicon octicon-git-branch select-menu-item-icon"></span>
            <div class="select-menu-item-text">
              <h4>Create branch: <span class="js-new-item-name"></span></h4>
              <span class="description">from ‘master’</span>
            </div>
            <input type="hidden" name="name" id="name" class="js-new-item-value">
            <input type="hidden" name="branch" id="branch" value="master">
            <input type="hidden" name="path" id="path" value="Assets/CharacterController2D.cs">
          </form> <!-- /.select-menu-item -->

      </div> <!-- /.select-menu-list -->

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div> <!-- /.select-menu-list -->

    </div> <!-- /.select-menu-modal -->
  </div> <!-- /.select-menu-modal-holder -->
</div> <!-- /.select-menu -->

  <div class="button-group right">
    <a href="/Mimerme/SuperMeatyController2D/find/master"
          class="js-show-file-finder minibutton empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button class="js-zeroclipboard minibutton zeroclipboard-button"
          data-clipboard-text="Assets/CharacterController2D.cs"
          aria-label="Copy to clipboard"
          data-copied-hint="Copied!">
      <span class="octicon octicon-clippy"></span>
    </button>
  </div>

  <div class="breadcrumb">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Mimerme/SuperMeatyController2D" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">SuperMeatyController2D</span></a></span></span><span class="separator"> / </span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/Mimerme/SuperMeatyController2D/tree/master/Assets" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">Assets</span></a></span><span class="separator"> / </span><strong class="final-path">CharacterController2D.cs</strong>
  </div>
</div>


  <div class="commit file-history-tease">
      <img alt="Mimerme" class="main-avatar" data-user="6308253" height="24" src="https://avatars2.githubusercontent.com/u/6308253?v=2&amp;s=48" width="24" />
      <span class="author"><a href="/Mimerme" rel="author">Mimerme</a></span>
      <time datetime="2014-04-13T16:55:09-04:00" is="relative-time">April 13, 2014</time>
      <div class="commit-title">
          <a href="/Mimerme/SuperMeatyController2D/commit/653806278e85c973fa98c5550af892e93132d3c0" class="message" data-pjax="true" title="Fixed Bug that did not allow air straifing">Fixed Bug that did not allow air straifing</a>
      </div>

    <div class="participation">
      <p class="quickstat"><a href="#blob_contributors_box" rel="facebox"><strong>1</strong>  contributor</a></p>
      
    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="Mimerme" data-user="6308253" height="24" src="https://avatars2.githubusercontent.com/u/6308253?v=2&amp;s=48" width="24" />
            <a href="/Mimerme">Mimerme</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file-box">
  <div class="file">
    <div class="meta clearfix">
      <div class="info file-name">
          <span>132 lines (110 sloc)</span>
          <span class="meta-divider"></span>
        <span>4.139 kb</span>
      </div>
      <div class="actions">
        <div class="button-group">
          <a href="/Mimerme/SuperMeatyController2D/raw/master/Assets/CharacterController2D.cs" class="minibutton " id="raw-url">Raw</a>
            <a href="/Mimerme/SuperMeatyController2D/blame/master/Assets/CharacterController2D.cs" class="minibutton js-update-url-with-hash">Blame</a>
          <a href="/Mimerme/SuperMeatyController2D/commits/master/Assets/CharacterController2D.cs" class="minibutton " rel="nofollow">History</a>
        </div><!-- /.button-group -->

          <a class="octicon-button tooltipped tooltipped-nw"
             href="github-windows://openRepo/https://github.com/Mimerme/SuperMeatyController2D?branch=master&amp;filepath=Assets%2FCharacterController2D.cs" aria-label="Open this file in GitHub for Windows">
              <span class="octicon octicon-device-desktop"></span>
          </a>

              <a class="octicon-button js-update-url-with-hash"
                 href="/Mimerme/SuperMeatyController2D/edit/master/Assets/CharacterController2D.cs"
                 data-method="post" rel="nofollow" data-hotkey="e"><span class="octicon octicon-pencil"></span></a>

            <a class="octicon-button danger"
               href="/Mimerme/SuperMeatyController2D/delete/master/Assets/CharacterController2D.cs"
               data-method="post" data-test-id="delete-blob-file" rel="nofollow">
          <span class="octicon octicon-trashcan"></span>
        </a>
      </div><!-- /.actions -->
    </div>
      
  <div class="blob-wrapper data type-c">
      <table class="highlight tab-size-8 js-file-line-container">
      <tr>
        <td id="L1" class="blob-line-num js-line-number" data-line-number="1"></td>
        <td id="LC1" class="blob-line-code js-file-line"><span class="k">using</span> <span class="nn">UnityEngine</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L2" class="blob-line-num js-line-number" data-line-number="2"></td>
        <td id="LC2" class="blob-line-code js-file-line"><span class="k">using</span> <span class="nn">System.Collections</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L3" class="blob-line-num js-line-number" data-line-number="3"></td>
        <td id="LC3" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L4" class="blob-line-num js-line-number" data-line-number="4"></td>
        <td id="LC4" class="blob-line-code js-file-line"><span class="k">public</span> <span class="k">class</span> <span class="nc">CharacterController2D</span> <span class="p">:</span> <span class="n">MonoBehaviour</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L5" class="blob-line-num js-line-number" data-line-number="5"></td>
        <td id="LC5" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L6" class="blob-line-num js-line-number" data-line-number="6"></td>
        <td id="LC6" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">float</span> <span class="n">upSpead</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L7" class="blob-line-num js-line-number" data-line-number="7"></td>
        <td id="LC7" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">float</span> <span class="n">jumpSpead</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L8" class="blob-line-num js-line-number" data-line-number="8"></td>
        <td id="LC8" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">bool</span> <span class="n">jumping</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L9" class="blob-line-num js-line-number" data-line-number="9"></td>
        <td id="LC9" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">bool</span> <span class="n">grounded</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L10" class="blob-line-num js-line-number" data-line-number="10"></td>
        <td id="LC10" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">string</span> <span class="n">sidesHit</span> <span class="p">=</span> <span class="s">&quot;none&quot;</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L11" class="blob-line-num js-line-number" data-line-number="11"></td>
        <td id="LC11" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="n">Vector2</span> <span class="n">down</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L12" class="blob-line-num js-line-number" data-line-number="12"></td>
        <td id="LC12" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="n">Vector2</span> <span class="n">sides</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L13" class="blob-line-num js-line-number" data-line-number="13"></td>
        <td id="LC13" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="n">Vector2</span> <span class="n">sideLeft</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L14" class="blob-line-num js-line-number" data-line-number="14"></td>
        <td id="LC14" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">float</span> <span class="n">skinWidth</span> <span class="p">=</span> <span class="m">0.1f</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L15" class="blob-line-num js-line-number" data-line-number="15"></td>
        <td id="LC15" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">float</span> <span class="n">InitalAcceleration</span> <span class="p">=</span> <span class="m">500</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L16" class="blob-line-num js-line-number" data-line-number="16"></td>
        <td id="LC16" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">float</span> <span class="n">airspeed</span> <span class="p">=</span> <span class="m">500</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L17" class="blob-line-num js-line-number" data-line-number="17"></td>
        <td id="LC17" class="blob-line-code js-file-line">	<span class="k">public</span> <span class="kt">bool</span> <span class="n">maxSpeed</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L18" class="blob-line-num js-line-number" data-line-number="18"></td>
        <td id="LC18" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L19" class="blob-line-num js-line-number" data-line-number="19"></td>
        <td id="LC19" class="blob-line-code js-file-line">	<span class="n">Vector2</span> <span class="n">start</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L20" class="blob-line-num js-line-number" data-line-number="20"></td>
        <td id="LC20" class="blob-line-code js-file-line">	<span class="n">RaycastHit2D</span> <span class="n">hit</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L21" class="blob-line-num js-line-number" data-line-number="21"></td>
        <td id="LC21" class="blob-line-code js-file-line">	<span class="k">void</span> <span class="nf">Start</span><span class="p">(){</span></td>
      </tr>
      <tr>
        <td id="L22" class="blob-line-num js-line-number" data-line-number="22"></td>
        <td id="LC22" class="blob-line-code js-file-line">		<span class="c1">//start = transform.position;</span></td>
      </tr>
      <tr>
        <td id="L23" class="blob-line-num js-line-number" data-line-number="23"></td>
        <td id="LC23" class="blob-line-code js-file-line">		<span class="c1">//start.y = transform.position.y - transform.localScale.y/2f;</span></td>
      </tr>
      <tr>
        <td id="L24" class="blob-line-num js-line-number" data-line-number="24"></td>
        <td id="LC24" class="blob-line-code js-file-line">		<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L25" class="blob-line-num js-line-number" data-line-number="25"></td>
        <td id="LC25" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L26" class="blob-line-num js-line-number" data-line-number="26"></td>
        <td id="LC26" class="blob-line-code js-file-line">	<span class="k">void</span> <span class="nf">Update</span> <span class="p">()</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L27" class="blob-line-num js-line-number" data-line-number="27"></td>
        <td id="LC27" class="blob-line-code js-file-line">	<span class="c1">//Basic ground checking code with Physics2d raycasting</span></td>
      </tr>
      <tr>
        <td id="L28" class="blob-line-num js-line-number" data-line-number="28"></td>
        <td id="LC28" class="blob-line-code js-file-line">		<span class="n">sideLeft</span> <span class="p">=</span> <span class="n">transform</span><span class="p">.</span><span class="n">position</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L29" class="blob-line-num js-line-number" data-line-number="29"></td>
        <td id="LC29" class="blob-line-code js-file-line">		<span class="n">sideLeft</span><span class="p">.</span><span class="n">x</span> <span class="p">=</span> <span class="n">transform</span><span class="p">.</span><span class="n">position</span><span class="p">.</span><span class="n">x</span> <span class="p">-</span> <span class="n">transform</span><span class="p">.</span><span class="n">localScale</span><span class="p">.</span><span class="n">x</span> <span class="p">/</span> <span class="m">2</span> <span class="p">-</span> <span class="m">0.1f</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L30" class="blob-line-num js-line-number" data-line-number="30"></td>
        <td id="LC30" class="blob-line-code js-file-line">		<span class="n">sides</span> <span class="p">=</span> <span class="n">transform</span><span class="p">.</span><span class="n">position</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L31" class="blob-line-num js-line-number" data-line-number="31"></td>
        <td id="LC31" class="blob-line-code js-file-line">		<span class="n">sides</span><span class="p">.</span><span class="n">x</span> <span class="p">=</span> <span class="n">transform</span><span class="p">.</span><span class="n">position</span><span class="p">.</span><span class="n">x</span> <span class="p">+</span> <span class="n">transform</span><span class="p">.</span><span class="n">localScale</span><span class="p">.</span><span class="n">x</span> <span class="p">/</span> <span class="m">2</span> <span class="p">+</span> <span class="m">0.1f</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L32" class="blob-line-num js-line-number" data-line-number="32"></td>
        <td id="LC32" class="blob-line-code js-file-line">		<span class="n">start</span> <span class="p">=</span> <span class="n">transform</span><span class="p">.</span><span class="n">position</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L33" class="blob-line-num js-line-number" data-line-number="33"></td>
        <td id="LC33" class="blob-line-code js-file-line">		<span class="n">start</span><span class="p">.</span><span class="n">y</span> <span class="p">=</span> <span class="n">transform</span><span class="p">.</span><span class="n">position</span><span class="p">.</span><span class="n">y</span> <span class="p">-</span> <span class="n">transform</span><span class="p">.</span><span class="n">localScale</span><span class="p">.</span><span class="n">y</span><span class="p">/</span><span class="m">2f</span> <span class="p">-</span> <span class="m">0.1f</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L34" class="blob-line-num js-line-number" data-line-number="34"></td>
        <td id="LC34" class="blob-line-code js-file-line">		<span class="n">Debug</span><span class="p">.</span><span class="n">DrawRay</span> <span class="p">(</span><span class="n">start</span><span class="p">,</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">up</span><span class="p">);</span></td>
      </tr>
      <tr>
        <td id="L35" class="blob-line-num js-line-number" data-line-number="35"></td>
        <td id="LC35" class="blob-line-code js-file-line">		<span class="n">Debug</span><span class="p">.</span><span class="n">DrawRay</span> <span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="n">start</span><span class="p">.</span><span class="n">x</span> <span class="p">-</span> <span class="n">transform</span><span class="p">.</span><span class="n">localScale</span><span class="p">.</span><span class="n">x</span><span class="p">/</span><span class="m">2</span><span class="p">,</span> <span class="n">start</span><span class="p">.</span><span class="n">y</span><span class="p">),</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">up</span><span class="p">);</span></td>
      </tr>
      <tr>
        <td id="L36" class="blob-line-num js-line-number" data-line-number="36"></td>
        <td id="LC36" class="blob-line-code js-file-line">		<span class="n">Debug</span><span class="p">.</span><span class="n">DrawRay</span> <span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="n">start</span><span class="p">.</span><span class="n">x</span> <span class="p">+</span> <span class="n">transform</span><span class="p">.</span><span class="n">localScale</span><span class="p">.</span><span class="n">x</span><span class="p">/</span><span class="m">2</span><span class="p">,</span> <span class="n">start</span><span class="p">.</span><span class="n">y</span><span class="p">),</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">up</span><span class="p">);</span></td>
      </tr>
      <tr>
        <td id="L37" class="blob-line-num js-line-number" data-line-number="37"></td>
        <td id="LC37" class="blob-line-code js-file-line">		<span class="n">Debug</span><span class="p">.</span><span class="n">DrawRay</span> <span class="p">(</span><span class="n">sides</span><span class="p">,</span> <span class="n">Vector2</span><span class="p">.</span><span class="n">right</span><span class="p">);</span></td>
      </tr>
      <tr>
        <td id="L38" class="blob-line-num js-line-number" data-line-number="38"></td>
        <td id="LC38" class="blob-line-code js-file-line">		<span class="n">Debug</span><span class="p">.</span><span class="n">DrawRay</span> <span class="p">(</span><span class="n">sideLeft</span><span class="p">,</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">right</span><span class="p">);</span></td>
      </tr>
      <tr>
        <td id="L39" class="blob-line-num js-line-number" data-line-number="39"></td>
        <td id="LC39" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L40" class="blob-line-num js-line-number" data-line-number="40"></td>
        <td id="LC40" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L41" class="blob-line-num js-line-number" data-line-number="41"></td>
        <td id="LC41" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Physics2D</span><span class="p">.</span><span class="n">Raycast</span> <span class="p">(</span><span class="n">start</span><span class="p">,</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">up</span><span class="p">,</span> <span class="n">skinWidth</span><span class="p">).</span><span class="n">collider</span> <span class="p">!=</span> <span class="k">null</span> <span class="p">||</span> <span class="n">Physics2D</span><span class="p">.</span><span class="n">Raycast</span> <span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="n">start</span><span class="p">.</span><span class="n">x</span> <span class="p">+</span> <span class="n">transform</span><span class="p">.</span><span class="n">localScale</span><span class="p">.</span><span class="n">x</span><span class="p">/</span><span class="m">2</span><span class="p">,</span> <span class="n">start</span><span class="p">.</span><span class="n">y</span><span class="p">),</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">up</span><span class="p">,</span> <span class="n">skinWidth</span><span class="p">).</span><span class="n">collider</span> <span class="p">!=</span> <span class="k">null</span> <span class="p">||</span> <span class="n">Physics2D</span><span class="p">.</span><span class="n">Raycast</span> <span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="n">start</span><span class="p">.</span><span class="n">x</span> <span class="p">-</span> <span class="n">transform</span><span class="p">.</span><span class="n">localScale</span><span class="p">.</span><span class="n">x</span><span class="p">/</span><span class="m">2</span><span class="p">,</span> <span class="n">start</span><span class="p">.</span><span class="n">y</span><span class="p">),</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">up</span><span class="p">,</span> <span class="n">skinWidth</span><span class="p">).</span><span class="n">collider</span> <span class="p">!=</span> <span class="k">null</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L42" class="blob-line-num js-line-number" data-line-number="42"></td>
        <td id="LC42" class="blob-line-code js-file-line">						<span class="n">grounded</span> <span class="p">=</span> <span class="k">true</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L43" class="blob-line-num js-line-number" data-line-number="43"></td>
        <td id="LC43" class="blob-line-code js-file-line">				<span class="p">}</span> <span class="k">else</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L44" class="blob-line-num js-line-number" data-line-number="44"></td>
        <td id="LC44" class="blob-line-code js-file-line">			<span class="n">grounded</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L45" class="blob-line-num js-line-number" data-line-number="45"></td>
        <td id="LC45" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L46" class="blob-line-num js-line-number" data-line-number="46"></td>
        <td id="LC46" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L47" class="blob-line-num js-line-number" data-line-number="47"></td>
        <td id="LC47" class="blob-line-code js-file-line">	</td>
      </tr>
      <tr>
        <td id="L48" class="blob-line-num js-line-number" data-line-number="48"></td>
        <td id="LC48" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetKeyUp</span><span class="p">(</span><span class="n">KeyCode</span><span class="p">.</span><span class="n">A</span><span class="p">)</span> <span class="p">&amp;&amp;</span> <span class="n">grounded</span> <span class="p">==</span> <span class="k">true</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L49" class="blob-line-num js-line-number" data-line-number="49"></td>
        <td id="LC49" class="blob-line-code js-file-line">			<span class="c1">//Detect when certain keys are released to reset velocity</span></td>
      </tr>
      <tr>
        <td id="L50" class="blob-line-num js-line-number" data-line-number="50"></td>
        <td id="LC50" class="blob-line-code js-file-line">			<span class="c1">//Reset the velocity to a number close to 0 to make a sudden stop, but ease out to fell smoother</span></td>
      </tr>
      <tr>
        <td id="L51" class="blob-line-num js-line-number" data-line-number="51"></td>
        <td id="LC51" class="blob-line-code js-file-line">			<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">velocity</span> <span class="p">=</span> <span class="k">new</span> <span class="n">Vector2</span><span class="p">(-</span><span class="m">2</span><span class="p">,</span><span class="m">0</span><span class="p">);</span></td>
      </tr>
      <tr>
        <td id="L52" class="blob-line-num js-line-number" data-line-number="52"></td>
        <td id="LC52" class="blob-line-code js-file-line">		<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L53" class="blob-line-num js-line-number" data-line-number="53"></td>
        <td id="LC53" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetKeyUp</span><span class="p">(</span><span class="n">KeyCode</span><span class="p">.</span><span class="n">D</span><span class="p">)</span> <span class="p">&amp;&amp;</span> <span class="n">grounded</span> <span class="p">==</span> <span class="k">true</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L54" class="blob-line-num js-line-number" data-line-number="54"></td>
        <td id="LC54" class="blob-line-code js-file-line">			<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">velocity</span> <span class="p">=</span> <span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="m">2</span><span class="p">,</span><span class="m">0</span><span class="p">);</span></td>
      </tr>
      <tr>
        <td id="L55" class="blob-line-num js-line-number" data-line-number="55"></td>
        <td id="LC55" class="blob-line-code js-file-line">		<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L56" class="blob-line-num js-line-number" data-line-number="56"></td>
        <td id="LC56" class="blob-line-code js-file-line">		<span class="c1">//Jumping Trigger</span></td>
      </tr>
      <tr>
        <td id="L57" class="blob-line-num js-line-number" data-line-number="57"></td>
        <td id="LC57" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetKeyDown</span> <span class="p">(</span><span class="n">KeyCode</span><span class="p">.</span><span class="n">Space</span><span class="p">))</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L58" class="blob-line-num js-line-number" data-line-number="58"></td>
        <td id="LC58" class="blob-line-code js-file-line">			<span class="k">if</span><span class="p">(</span><span class="n">grounded</span> <span class="p">==</span> <span class="k">true</span><span class="p">){</span></td>
      </tr>
      <tr>
        <td id="L59" class="blob-line-num js-line-number" data-line-number="59"></td>
        <td id="LC59" class="blob-line-code js-file-line">			<span class="n">jumping</span> <span class="p">=</span> <span class="k">true</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L60" class="blob-line-num js-line-number" data-line-number="60"></td>
        <td id="LC60" class="blob-line-code js-file-line">				<span class="c1">//Add the Initial Accleration to make the player shoot up, and then slow down, then fall</span></td>
      </tr>
      <tr>
        <td id="L61" class="blob-line-num js-line-number" data-line-number="61"></td>
        <td id="LC61" class="blob-line-code js-file-line">				<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="m">0</span><span class="p">,</span><span class="n">InitalAcceleration</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L62" class="blob-line-num js-line-number" data-line-number="62"></td>
        <td id="LC62" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L63" class="blob-line-num js-line-number" data-line-number="63"></td>
        <td id="LC63" class="blob-line-code js-file-line">			<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L64" class="blob-line-num js-line-number" data-line-number="64"></td>
        <td id="LC64" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L65" class="blob-line-num js-line-number" data-line-number="65"></td>
        <td id="LC65" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetKeyUp</span> <span class="p">(</span><span class="n">KeyCode</span><span class="p">.</span><span class="n">Space</span><span class="p">))</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L66" class="blob-line-num js-line-number" data-line-number="66"></td>
        <td id="LC66" class="blob-line-code js-file-line">			<span class="n">jumping</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L67" class="blob-line-num js-line-number" data-line-number="67"></td>
        <td id="LC67" class="blob-line-code js-file-line">		<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L68" class="blob-line-num js-line-number" data-line-number="68"></td>
        <td id="LC68" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetKey</span> <span class="p">(</span><span class="n">KeyCode</span><span class="p">.</span><span class="n">Space</span><span class="p">))</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L69" class="blob-line-num js-line-number" data-line-number="69"></td>
        <td id="LC69" class="blob-line-code js-file-line">			<span class="k">if</span><span class="p">(</span><span class="n">jumping</span> <span class="p">==</span><span class="k">true</span><span class="p">){</span></td>
      </tr>
      <tr>
        <td id="L70" class="blob-line-num js-line-number" data-line-number="70"></td>
        <td id="LC70" class="blob-line-code js-file-line">				<span class="c1">//Detect if speed limit is reached, and then fall back down</span></td>
      </tr>
      <tr>
        <td id="L71" class="blob-line-num js-line-number" data-line-number="71"></td>
        <td id="LC71" class="blob-line-code js-file-line">			<span class="k">if</span><span class="p">(</span><span class="n">rigidbody2D</span><span class="p">.</span><span class="n">velocity</span><span class="p">.</span><span class="n">y</span> <span class="p">&gt;=</span><span class="m">10</span><span class="p">){</span></td>
      </tr>
      <tr>
        <td id="L72" class="blob-line-num js-line-number" data-line-number="72"></td>
        <td id="LC72" class="blob-line-code js-file-line">				<span class="n">jumping</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L73" class="blob-line-num js-line-number" data-line-number="73"></td>
        <td id="LC73" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L74" class="blob-line-num js-line-number" data-line-number="74"></td>
        <td id="LC74" class="blob-line-code js-file-line">				<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="m">0</span><span class="p">,</span><span class="n">jumpSpead</span> <span class="p">*</span> <span class="n">Time</span><span class="p">.</span><span class="n">deltaTime</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L75" class="blob-line-num js-line-number" data-line-number="75"></td>
        <td id="LC75" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L76" class="blob-line-num js-line-number" data-line-number="76"></td>
        <td id="LC76" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L77" class="blob-line-num js-line-number" data-line-number="77"></td>
        <td id="LC77" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L78" class="blob-line-num js-line-number" data-line-number="78"></td>
        <td id="LC78" class="blob-line-code js-file-line">			<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L79" class="blob-line-num js-line-number" data-line-number="79"></td>
        <td id="LC79" class="blob-line-code js-file-line">		<span class="c1">//Detect sides by raycastting. Possibly can be used for wall jumping</span></td>
      </tr>
      <tr>
        <td id="L80" class="blob-line-num js-line-number" data-line-number="80"></td>
        <td id="LC80" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Physics2D</span><span class="p">.</span><span class="n">Raycast</span> <span class="p">(</span><span class="n">sides</span><span class="p">,</span> <span class="n">Vector2</span><span class="p">.</span><span class="n">right</span><span class="p">,</span> <span class="n">skinWidth</span><span class="p">).</span><span class="n">collider</span> <span class="p">!=</span> <span class="k">null</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L81" class="blob-line-num js-line-number" data-line-number="81"></td>
        <td id="LC81" class="blob-line-code js-file-line">						<span class="n">sidesHit</span> <span class="p">=</span> <span class="s">&quot;right&quot;</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L82" class="blob-line-num js-line-number" data-line-number="82"></td>
        <td id="LC82" class="blob-line-code js-file-line">		<span class="p">}</span> <span class="k">else</span> <span class="k">if</span> <span class="p">(</span><span class="n">Physics2D</span><span class="p">.</span><span class="n">Raycast</span> <span class="p">(</span><span class="n">sideLeft</span><span class="p">,</span> <span class="p">-</span><span class="n">Vector2</span><span class="p">.</span><span class="n">right</span><span class="p">,</span> <span class="n">skinWidth</span><span class="p">).</span><span class="n">collider</span> <span class="p">!=</span> <span class="k">null</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L83" class="blob-line-num js-line-number" data-line-number="83"></td>
        <td id="LC83" class="blob-line-code js-file-line">			<span class="n">sidesHit</span> <span class="p">=</span> <span class="s">&quot;left&quot;</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L84" class="blob-line-num js-line-number" data-line-number="84"></td>
        <td id="LC84" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L85" class="blob-line-num js-line-number" data-line-number="85"></td>
        <td id="LC85" class="blob-line-code js-file-line">			<span class="k">else</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L86" class="blob-line-num js-line-number" data-line-number="86"></td>
        <td id="LC86" class="blob-line-code js-file-line">			<span class="n">sidesHit</span> <span class="p">=</span> <span class="s">&quot;none&quot;</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L87" class="blob-line-num js-line-number" data-line-number="87"></td>
        <td id="LC87" class="blob-line-code js-file-line">			</td>
      </tr>
      <tr>
        <td id="L88" class="blob-line-num js-line-number" data-line-number="88"></td>
        <td id="LC88" class="blob-line-code js-file-line">		<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L89" class="blob-line-num js-line-number" data-line-number="89"></td>
        <td id="LC89" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L90" class="blob-line-num js-line-number" data-line-number="90"></td>
        <td id="LC90" class="blob-line-code js-file-line">		<span class="n">Move</span> <span class="p">();</span></td>
      </tr>
      <tr>
        <td id="L91" class="blob-line-num js-line-number" data-line-number="91"></td>
        <td id="LC91" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L92" class="blob-line-num js-line-number" data-line-number="92"></td>
        <td id="LC92" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L93" class="blob-line-num js-line-number" data-line-number="93"></td>
        <td id="LC93" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L94" class="blob-line-num js-line-number" data-line-number="94"></td>
        <td id="LC94" class="blob-line-code js-file-line">	<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L95" class="blob-line-num js-line-number" data-line-number="95"></td>
        <td id="LC95" class="blob-line-code js-file-line">	<span class="k">void</span> <span class="nf">Move</span><span class="p">(){</span></td>
      </tr>
      <tr>
        <td id="L96" class="blob-line-num js-line-number" data-line-number="96"></td>
        <td id="LC96" class="blob-line-code js-file-line">		<span class="c1">//Move in air code</span></td>
      </tr>
      <tr>
        <td id="L97" class="blob-line-num js-line-number" data-line-number="97"></td>
        <td id="LC97" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetAxisRaw</span> <span class="p">(</span><span class="s">&quot;Horizontal&quot;</span><span class="p">)</span> <span class="p">&lt;</span> <span class="m">0</span> <span class="p">&amp;&amp;</span> <span class="n">grounded</span> <span class="p">==</span> <span class="k">false</span> <span class="p">&amp;&amp;</span> <span class="n">maxSpeed</span> <span class="p">==</span> <span class="k">true</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L98" class="blob-line-num js-line-number" data-line-number="98"></td>
        <td id="LC98" class="blob-line-code js-file-line">			<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="n">airspeed</span> <span class="p">*</span> <span class="n">Time</span><span class="p">.</span><span class="n">deltaTime</span><span class="p">,</span><span class="m">0</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L99" class="blob-line-num js-line-number" data-line-number="99"></td>
        <td id="LC99" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L100" class="blob-line-num js-line-number" data-line-number="100"></td>
        <td id="LC100" class="blob-line-code js-file-line">		<span class="k">else</span> <span class="nf">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetAxisRaw</span> <span class="p">(</span><span class="s">&quot;Horizontal&quot;</span><span class="p">)</span> <span class="p">&gt;</span> <span class="m">0</span> <span class="p">&amp;&amp;</span> <span class="n">grounded</span> <span class="p">==</span> <span class="k">false</span> <span class="p">&amp;&amp;</span> <span class="n">maxSpeed</span> <span class="p">==</span> <span class="k">true</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L101" class="blob-line-num js-line-number" data-line-number="101"></td>
        <td id="LC101" class="blob-line-code js-file-line">			<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(-</span><span class="n">airspeed</span> <span class="p">*</span> <span class="n">Time</span><span class="p">.</span><span class="n">deltaTime</span><span class="p">,</span><span class="m">0</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L102" class="blob-line-num js-line-number" data-line-number="102"></td>
        <td id="LC102" class="blob-line-code js-file-line">		<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L103" class="blob-line-num js-line-number" data-line-number="103"></td>
        <td id="LC103" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L104" class="blob-line-num js-line-number" data-line-number="104"></td>
        <td id="LC104" class="blob-line-code js-file-line">		<span class="c1">//Move Left/Right Code</span></td>
      </tr>
      <tr>
        <td id="L105" class="blob-line-num js-line-number" data-line-number="105"></td>
        <td id="LC105" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">rigidbody2D</span><span class="p">.</span><span class="n">velocity</span><span class="p">.</span><span class="n">x</span> <span class="p">&gt;=</span> <span class="m">9</span> <span class="p">||</span> <span class="n">rigidbody2D</span><span class="p">.</span><span class="n">velocity</span><span class="p">.</span><span class="n">x</span> <span class="p">&lt;=</span> <span class="p">-</span><span class="m">9</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L106" class="blob-line-num js-line-number" data-line-number="106"></td>
        <td id="LC106" class="blob-line-code js-file-line">						<span class="n">maxSpeed</span> <span class="p">=</span> <span class="k">true</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L107" class="blob-line-num js-line-number" data-line-number="107"></td>
        <td id="LC107" class="blob-line-code js-file-line">				<span class="p">}</span> <span class="k">else</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L108" class="blob-line-num js-line-number" data-line-number="108"></td>
        <td id="LC108" class="blob-line-code js-file-line">			<span class="k">if</span><span class="p">(</span><span class="n">maxSpeed</span> <span class="p">==</span> <span class="k">true</span><span class="p">){</span></td>
      </tr>
      <tr>
        <td id="L109" class="blob-line-num js-line-number" data-line-number="109"></td>
        <td id="LC109" class="blob-line-code js-file-line">				<span class="n">maxSpeed</span> <span class="p">=</span> <span class="k">false</span><span class="p">;</span></td>
      </tr>
      <tr>
        <td id="L110" class="blob-line-num js-line-number" data-line-number="110"></td>
        <td id="LC110" class="blob-line-code js-file-line">			<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L111" class="blob-line-num js-line-number" data-line-number="111"></td>
        <td id="LC111" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L112" class="blob-line-num js-line-number" data-line-number="112"></td>
        <td id="LC112" class="blob-line-code js-file-line">		</td>
      </tr>
      <tr>
        <td id="L113" class="blob-line-num js-line-number" data-line-number="113"></td>
        <td id="LC113" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetAxisRaw</span> <span class="p">(</span><span class="s">&quot;Horizontal&quot;</span><span class="p">)</span> <span class="p">&lt;</span> <span class="m">0</span> <span class="p">&amp;&amp;</span> <span class="n">sidesHit</span> <span class="p">!=</span> <span class="s">&quot;left&quot;</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L114" class="blob-line-num js-line-number" data-line-number="114"></td>
        <td id="LC114" class="blob-line-code js-file-line">			<span class="k">if</span> <span class="p">(</span><span class="n">maxSpeed</span> <span class="p">==</span> <span class="k">false</span> <span class="p">&amp;&amp;</span> <span class="n">grounded</span> <span class="p">==</span> <span class="k">false</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L115" class="blob-line-num js-line-number" data-line-number="115"></td>
        <td id="LC115" class="blob-line-code js-file-line">				<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(-</span><span class="n">airspeed</span> <span class="p">*</span> <span class="n">Time</span><span class="p">.</span><span class="n">deltaTime</span><span class="p">,</span><span class="m">0</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L116" class="blob-line-num js-line-number" data-line-number="116"></td>
        <td id="LC116" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L117" class="blob-line-num js-line-number" data-line-number="117"></td>
        <td id="LC117" class="blob-line-code js-file-line">			<span class="p">}</span><span class="k">else</span> <span class="k">if</span><span class="p">(</span><span class="n">maxSpeed</span> <span class="p">==</span> <span class="k">false</span><span class="p">){</span></td>
      </tr>
      <tr>
        <td id="L118" class="blob-line-num js-line-number" data-line-number="118"></td>
        <td id="LC118" class="blob-line-code js-file-line">			<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(-</span><span class="n">upSpead</span> <span class="p">*</span> <span class="n">Time</span><span class="p">.</span><span class="n">deltaTime</span><span class="p">,</span><span class="m">0</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L119" class="blob-line-num js-line-number" data-line-number="119"></td>
        <td id="LC119" class="blob-line-code js-file-line">				<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L120" class="blob-line-num js-line-number" data-line-number="120"></td>
        <td id="LC120" class="blob-line-code js-file-line">			<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L121" class="blob-line-num js-line-number" data-line-number="121"></td>
        <td id="LC121" class="blob-line-code js-file-line">		<span class="k">if</span> <span class="p">(</span><span class="n">Input</span><span class="p">.</span><span class="n">GetAxisRaw</span> <span class="p">(</span><span class="s">&quot;Horizontal&quot;</span><span class="p">)</span> <span class="p">&gt;</span> <span class="m">0</span> <span class="p">&amp;&amp;</span> <span class="n">sidesHit</span> <span class="p">!=</span> <span class="s">&quot;right&quot;</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L122" class="blob-line-num js-line-number" data-line-number="122"></td>
        <td id="LC122" class="blob-line-code js-file-line">			<span class="k">if</span> <span class="p">(</span><span class="n">maxSpeed</span> <span class="p">==</span> <span class="k">false</span> <span class="p">&amp;&amp;</span> <span class="n">grounded</span> <span class="p">==</span> <span class="k">false</span><span class="p">)</span> <span class="p">{</span></td>
      </tr>
      <tr>
        <td id="L123" class="blob-line-num js-line-number" data-line-number="123"></td>
        <td id="LC123" class="blob-line-code js-file-line">				<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="n">airspeed</span> <span class="p">*</span> <span class="n">Time</span><span class="p">.</span><span class="n">deltaTime</span><span class="p">,</span><span class="m">0</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L124" class="blob-line-num js-line-number" data-line-number="124"></td>
        <td id="LC124" class="blob-line-code js-file-line">				</td>
      </tr>
      <tr>
        <td id="L125" class="blob-line-num js-line-number" data-line-number="125"></td>
        <td id="LC125" class="blob-line-code js-file-line">			<span class="p">}</span><span class="k">else</span> <span class="k">if</span><span class="p">(</span><span class="n">maxSpeed</span> <span class="p">==</span> <span class="k">false</span><span class="p">){</span></td>
      </tr>
      <tr>
        <td id="L126" class="blob-line-num js-line-number" data-line-number="126"></td>
        <td id="LC126" class="blob-line-code js-file-line">			<span class="n">rigidbody2D</span><span class="p">.</span><span class="n">AddForce</span><span class="p">(</span><span class="k">new</span> <span class="n">Vector2</span><span class="p">(</span><span class="n">upSpead</span> <span class="p">*</span> <span class="n">Time</span><span class="p">.</span><span class="n">deltaTime</span><span class="p">,</span><span class="m">0</span><span class="p">));</span></td>
      </tr>
      <tr>
        <td id="L127" class="blob-line-num js-line-number" data-line-number="127"></td>
        <td id="LC127" class="blob-line-code js-file-line">			<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L128" class="blob-line-num js-line-number" data-line-number="128"></td>
        <td id="LC128" class="blob-line-code js-file-line">		<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L129" class="blob-line-num js-line-number" data-line-number="129"></td>
        <td id="LC129" class="blob-line-code js-file-line">
</td>
      </tr>
      <tr>
        <td id="L130" class="blob-line-num js-line-number" data-line-number="130"></td>
        <td id="LC130" class="blob-line-code js-file-line">	<span class="p">}</span></td>
      </tr>
      <tr>
        <td id="L131" class="blob-line-num js-line-number" data-line-number="131"></td>
        <td id="LC131" class="blob-line-code js-file-line"><span class="p">}</span></td>
      </tr>
</table>

  </div>

  </div>
</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" class="js-jump-to-line-form">
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="button">Go</button>
  </form>
</div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer">
    <ul class="site-footer-links right">
      <li><a href="https://status.github.com/">Status</a></li>
      <li><a href="http://developer.github.com">API</a></li>
      <li><a href="http://training.github.com">Training</a></li>
      <li><a href="http://shop.github.com">Shop</a></li>
      <li><a href="/blog">Blog</a></li>
      <li><a href="/about">About</a></li>

    </ul>

    <a href="/" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
    </a>

    <ul class="site-footer-links">
      <li>&copy; 2014 <span title="0.04620s from github-fe122-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="/site/terms">Terms</a></li>
        <li><a href="/site/privacy">Privacy</a></li>
        <li><a href="/security">Security</a></li>
        <li><a href="/contact">Contact</a></li>
    </ul>
  </div><!-- /.site-footer -->
</div><!-- /.container -->


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents js-suggester-field" placeholder=""></textarea>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-12d5fda141e78e513749dddbc56445fe172cbd9a.js" type="text/javascript"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-14e2a44e296739b8ec8d7763e88ed307a6d424e0.js" type="text/javascript"></script>
      
      
        <script async src="https://www.google-analytics.com/analytics.js"></script>
  </body>
</html>

