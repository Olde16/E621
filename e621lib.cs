namespace e621lib
{
    public class Post
    {
        public long? approver_id;
        public long? change_seq;
        public long? comment_count;
        public string? created_at;
        public string? description;
        public decimal? duration;
        public long? fav_count;
        public Post_File? file;
        public Flags? flags;
        public bool has_notes;
        public long id;
        public bool is_favorited;
        public string[]? locked_tags;
        public string[]? pools;
        public Preview? preview;
        public string? rating;
        public Relationships? relationships;
        public Sample? sample;
        public Score? score;
        public string[]? sources;
        public Tags? tags;
        public string? updated_at;
        public long? uploader_id;

        public class Post_File
        {
            public uint? width;
            public uint? hight;
            public string? ext;
            public long? size;
            public string? md5;
            public string? url;
        }

        public class Flags
        {
            public bool pending;
            public bool flagged;
            public bool note_locked;
            public bool status_locked;
            public bool rating_locked;
            public bool deleted;
        }
        public class Preview
        {
            public uint? width;
            public uint? hight;
            public string? url;
        }
        public class Relationships
        {
            public long? parent_id;
            public bool has_children;
            public bool has_active_children;
            public long[]? children;
        }
        public class Sample
        {
            public bool has;
            public uint? width;
            public uint? hight;
            public string? url;
            public List<Post>? alternates;
        }
        public class Score
        {
            public long? up;
            public long? down;
            public long? total;
        }
        public class Tags
        {
            public string[]? general;
            public string[]? species;
            public string[]? character;
            public string[]? copyright;
            public string[]? artist;
            public string[]? invalid;
            public string[]? lore;
            public string[]? meta;
        }
    }
    public class Page
    {
        Post[]? posts;
        public long page_id {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                } 
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long postsCnt {
            get
            {
                if (this.posts != null)
                {
                    return this.posts.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class User
    {
        // - public info START
        public long? wiki_page_version_count;
        public long? artist_version_count; 
        public long? pool_version_count; 
        public long? forum_post_count; 
        public long? comment_count;
        public long? flag_count;
        public long? favorite_count; 
        public long? positive_feedback_count;
        public long? neutral_feedback_count; 
        public long? negative_feedback_count; 
        public long? upload_limit; 
        public long id; 
        public string? created_at;
        public string? name;
        public long? level;
        public long? base_upload_limit;
        public long? post_upload_count;
        public long? post_update_count;
        public long? note_update_count;
        public bool? is_banned;
        public bool? can_approve_posts;
        public bool? can_upload_free;
        public string? level_string;
        public long? avatar_id;
        // - public info END
        public bool? show_avatars;
        public bool? blacklist_avatars;
        public bool? blacklist_users;
        public bool? description_collapsed_initially;
        public bool? hide_comments;
        public bool? show_hidden_comments;
        public bool? show_post_statistics;
        public bool? has_mail;
        public bool? receive_email_notifications;
        public bool? enable_keyboard_navigation;
        public bool? enable_privacy_mode;
        public bool? style_usernames;
        public bool? enable_auto_complete;
        public bool? has_saved_searches;
        public bool? disable_cropped_thumbnails;
        public bool? disable_mobile_gestures;
        public bool? enable_safe_mode;
        public bool? disable_responsive_mode;
        public bool? disable_post_tooltips;
        public bool? no_flagging;
        public bool? no_feedback;
        public bool? disable_user_dmails;
        public bool? enable_compact_uploader;
        public bool? replacements_beta;
        public bool? is_bd_staff;
        public string? updated_at;
        public string? email;
        public string? last_logged_in_at;
        public string? last_forum_read_at;
        public string? recent_tags; // string?
        public long? comment_threshold;
        public string? default_image_size;
        public string? favorite_tags; // string?
        public string? blacklisted_tags; // string?
        public string? time_zone;
        public short? per_page;
        public string? custom_style;
        public short? api_regen_multiplier;
        public short? api_burst_limit;
        public int? remaining_api_limit;
        public long? statement_timeout;
        public long? favorite_limit;
        public int? tag_query_limit;

        public string apiKey
        {
            get
            {
                return this.apiKey;
            }
            set
            {
                if (value == null)
                {
                    this.apiKey = "";
                } else
                {
                    this.apiKey = value;
                }
            }
        }
    }
    public class Users
    {
        public User[]? users;
        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long userCnt
        {
            get
            {
                if (this.users != null)
                {
                    return this.users.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class URL
    {
        public long id;
        public long artist_id;
        public string? url;
        public string? normalized_url;
        public string? created_at;
        public string? updated_at;
        public bool? is_active;
    }
    public class Artist
    {
        public long id;
        public string? name;
        public string? updated_at;
        public bool is_active;
        public string[]? other_names;
        public string? group_name;
        public long? linked_user_id;
        public string? created_at;
        public long creator_id;
        public bool is_locked;
        public string? notes;
        public URL[]? urls;
    }
    public class Artists
    {
        Artist[]? artists;
        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long artistsCnt
        {
            get
            {
                if (this.artists != null)
                {
                    return this.artists.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class Tag
    {
        public long id;
        public string? name;
        public long? post_count;
        public string? related_tags;
        public string? related_tags_updated_at;
        public short? category;
        public bool? is_locked;
        public string? created_at;
        public string? updated_at;
    }
    public class Tags
    {
        Tag[]? tags;
        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long tagCnt
        {
            get
            {
                if (this.tags != null)
                {
                    return this.tags.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class Comments
    {
        public Post[]? posts;

        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long commentCnt
        {
            get
            {
                if (this.posts != null)
                {
                    return this.posts.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class Blip
    {
        public long id;
        public long creator_id;
        public string? body;
        public long response_to;
        public string? created_at;
        public string? updated_at;
        public bool? is_hidden;
        public string? warning_type;
        public long? warning_user_id;
        public string? creator_name;
    }
    public class Blips
    {
        Blip[]? blips;

        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long blipCnt
        {
            get
            {
                if (this.blips != null)
                {
                    return this.blips.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class Pool
    {
        public long id;
        public string? name;
        public string? created_at;
        public string? updated_at;
        public long? creator_id;
        public string? description;
        public bool? is_active;
        public string? category;
        public long[]? post_ids;
        public string? creator_name;
        public long? post_count;
    }
    public class Pools {
        public Pool[]? pools;

        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long commentCnt
        {
            get
            {
                if (this.pools != null)
                {
                    return this.pools.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class Set
    {
        public long id;
        public string? created_at;
        public string? updated_at;
        public long creator_id;
        public bool is_public;
        public string? name;
        public string? shortname;
        public string? description;
        public long? post_count;
        public bool? transfer_on_delete;
        public long[]? post_ids;
    }
    public class Sets
    {
        public Set[]? sets;

        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long commentCnt
        {
            get
            {
                if (this.sets != null)
                {
                    return this.sets.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class WikiPost
    {
        public long id;
        public string? created_at;
        public string? updated_at;
        public string? title;
        public string? body;
        public long creator_id;
        public bool? is_locked;
        public long? updater_id;
        public bool? is_deleted;
        public string[]? other_names;
        public string? creator_name;
        public int? category_id;
        public int? category_name; // why int?
    }
    public class WikiPage
    {
        public WikiPost[]? wikiPosts;
        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long pageCnt
        {
            get
            {
                if (this.wikiPosts != null)
                {
                    return this.wikiPosts.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class ForumPost
    {
        public long id;
        public long? creator_id;
        public long? updater_id;
        public string? title;
        public long? response_count;
        public bool? is_sticky;
        public bool? is_locked;
        public bool? is_hidden;
        public string? created_at;
        public string? updated_at;
        public long? category_id;
    }
    public class ForumPage
    {
        public ForumPost[]? forumPosts;
        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long pageCnt
        {
            get
            {
                if (this.forumPosts != null)
                {
                    return this.forumPosts.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }
    public class HelpPost
    {
        public long id;
        public string? name;
        public string? title;
        public string? wiki_page;
        public string? related;
        public string? created_at;
        public string? updated_at;
    }
    public class HelpPage
    {
        public HelpPost[]? helpPosts;
        public long page_id
        {
            get
            {
                return this.page_id;
            }
            set
            {
                if (value >= 0)
                {
                    this.page_id = value;
                }
                else
                {
                    this.page_id = default(long);
                }
            }
        }
        public long pageCnt
        {
            get
            {
                if (this.helpPosts != null)
                {
                    return this.helpPosts.Length;
                }
                else
                {
                    return default(long);
                }
            }
        }
    }

}
