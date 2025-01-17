﻿// <auto-generated />
using System;
using GeekOff.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace geek_off_angular.Migrations
{
    [DbContext(typeof(ContextGo))]
    partial class contextGoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("GeekOff.Data.CurrentQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("QuestionNum")
                        .HasColumnType("integer")
                        .HasColumnName("question_num");

                    b.Property<DateTime>("QuestionTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("question_time");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("yEvent")
                        .HasColumnType("text")
                        .HasColumnName("y_event");

                    b.HasKey("Id");

                    b.ToTable("current_question");
                });

            modelBuilder.Entity("GeekOff.Data.CurrentTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("RoundNo")
                        .HasColumnType("integer")
                        .HasColumnName("round_no");

                    b.Property<int>("TeamNo")
                        .HasColumnType("integer")
                        .HasColumnName("team_no");

                    b.HasKey("Id");

                    b.ToTable("current_team");
                });

            modelBuilder.Entity("GeekOff.Data.EventMaster", b =>
                {
                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.Property<string>("EventName")
                        .HasColumnType("text")
                        .HasColumnName("event_name");

                    b.Property<bool?>("SelEvent")
                        .HasColumnType("boolean")
                        .HasColumnName("sel_event");

                    b.HasKey("Yevent");

                    b.ToTable("event_master");

                    b.HasData(
                        new
                        {
                            Yevent = "e21",
                            EventName = "Employee 2021",
                            SelEvent = true
                        },
                        new
                        {
                            Yevent = "e19",
                            EventName = "Employee 2019"
                        });
                });

            modelBuilder.Entity("GeekOff.Data.FundraisingTotal", b =>
                {
                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.Property<decimal?>("Totaldollar")
                        .HasColumnType("numeric")
                        .HasColumnName("totaldollar");

                    b.HasKey("Yevent");

                    b.ToTable("fundraising_total");
                });

            modelBuilder.Entity("GeekOff.Data.QuestionAns", b =>
                {
                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.Property<int>("RoundNo")
                        .HasColumnType("integer")
                        .HasColumnName("round_no");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("integer")
                        .HasColumnName("question_no");

                    b.Property<string>("CorrectAnswer")
                        .HasColumnType("text")
                        .HasColumnName("correct_answer");

                    b.Property<bool?>("MatchQuestion")
                        .HasColumnType("boolean")
                        .HasColumnName("match_question");

                    b.Property<string>("MediaFile")
                        .HasColumnType("text")
                        .HasColumnName("media_file");

                    b.Property<string>("MediaType")
                        .HasColumnType("text")
                        .HasColumnName("media_type");

                    b.Property<bool?>("MultipleChoice")
                        .HasColumnType("boolean")
                        .HasColumnName("multiple_choice");

                    b.Property<string>("TextAnswer")
                        .HasColumnType("text")
                        .HasColumnName("text_answer");

                    b.Property<string>("TextAnswer2")
                        .HasColumnType("text")
                        .HasColumnName("text_answer2");

                    b.Property<string>("TextAnswer3")
                        .HasColumnType("text")
                        .HasColumnName("text_answer3");

                    b.Property<string>("TextAnswer4")
                        .HasColumnType("text")
                        .HasColumnName("text_answer4");

                    b.Property<string>("TextQuestion")
                        .HasColumnType("text")
                        .HasColumnName("text_question");

                    b.HasKey("Yevent", "RoundNo", "QuestionNo");

                    b.ToTable("question_ans");

                    b.HasData(
                        new
                        {
                            Yevent = "e21",
                            RoundNo = 2,
                            QuestionNo = 201,
                            TextQuestion = "Name your favorite developer."
                        });
                });

            modelBuilder.Entity("GeekOff.Data.Roundresult", b =>
                {
                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.Property<int>("RoundNo")
                        .HasColumnType("integer")
                        .HasColumnName("round_no");

                    b.Property<int>("TeamNo")
                        .HasColumnType("integer")
                        .HasColumnName("team_no");

                    b.Property<decimal?>("Ptswithbonus")
                        .HasColumnType("numeric")
                        .HasColumnName("ptswithbonus");

                    b.Property<int?>("rnk")
                        .HasColumnType("integer")
                        .HasColumnName("rnk");

                    b.HasKey("Yevent", "RoundNo", "TeamNo");

                    b.ToTable("roundresult");
                });

            modelBuilder.Entity("GeekOff.Data.Scoreposs", b =>
                {
                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.Property<int>("RoundNo")
                        .HasColumnType("integer")
                        .HasColumnName("round_no");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("integer")
                        .HasColumnName("question_no");

                    b.Property<int>("SurveyOrder")
                        .HasColumnType("integer")
                        .HasColumnName("survey_order");

                    b.Property<int?>("Ptsposs")
                        .HasColumnType("integer")
                        .HasColumnName("ptsposs");

                    b.Property<string>("QuestionAnswer")
                        .HasColumnType("text")
                        .HasColumnName("question_answer");

                    b.HasKey("Yevent", "RoundNo", "QuestionNo", "SurveyOrder");

                    b.ToTable("scoreposs");

                    b.HasData(
                        new
                        {
                            Yevent = "e21",
                            RoundNo = 2,
                            QuestionNo = 201,
                            SurveyOrder = 1,
                            Ptsposs = 8,
                            QuestionAnswer = "Kevin"
                        },
                        new
                        {
                            Yevent = "e21",
                            RoundNo = 2,
                            QuestionNo = 201,
                            SurveyOrder = 2,
                            Ptsposs = 7,
                            QuestionAnswer = "Kristin"
                        },
                        new
                        {
                            Yevent = "e21",
                            RoundNo = 2,
                            QuestionNo = 201,
                            SurveyOrder = 3,
                            Ptsposs = 6,
                            QuestionAnswer = "Diyalo"
                        },
                        new
                        {
                            Yevent = "e21",
                            RoundNo = 2,
                            QuestionNo = 201,
                            SurveyOrder = 4,
                            Ptsposs = 6,
                            QuestionAnswer = "Li"
                        },
                        new
                        {
                            Yevent = "e21",
                            RoundNo = 2,
                            QuestionNo = 201,
                            SurveyOrder = 5,
                            Ptsposs = 5,
                            QuestionAnswer = "Dan"
                        });
                });

            modelBuilder.Entity("GeekOff.Data.Scoring", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("FinalJep")
                        .HasColumnType("integer")
                        .HasColumnName("final_jep");

                    b.Property<int?>("PlayerNum")
                        .HasColumnType("integer")
                        .HasColumnName("player_num");

                    b.Property<int?>("PointAmt")
                        .HasColumnType("integer")
                        .HasColumnName("point_amt");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("integer")
                        .HasColumnName("question_no");

                    b.Property<int?>("Round3neg")
                        .HasColumnType("integer")
                        .HasColumnName("round3neg");

                    b.Property<int>("RoundNo")
                        .HasColumnType("integer")
                        .HasColumnName("round_no");

                    b.Property<string>("TeamAnswer")
                        .HasColumnType("text")
                        .HasColumnName("team_answer");

                    b.Property<int>("TeamNo")
                        .HasColumnType("integer")
                        .HasColumnName("team_no");

                    b.Property<DateTime>("Updatetime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updatetime");

                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.HasKey("Id");

                    b.ToTable("scoring");
                });

            modelBuilder.Entity("GeekOff.Data.TeamUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("AdminFlag")
                        .HasColumnType("boolean")
                        .HasColumnName("admin_flag");

                    b.Property<string>("BadgeId")
                        .HasColumnType("text")
                        .HasColumnName("badge_id");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("login_time");

                    b.Property<string>("PlayerName")
                        .HasColumnType("text")
                        .HasColumnName("player_name");

                    b.Property<int?>("PlayerNum")
                        .HasColumnType("integer")
                        .HasColumnName("player_num");

                    b.Property<int>("TeamNo")
                        .HasColumnType("integer")
                        .HasColumnName("team_no");

                    b.Property<string>("Username")
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.Property<string>("WorkgroupName")
                        .HasColumnType("text")
                        .HasColumnName("workgroup_name");

                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.HasKey("Id");

                    b.ToTable("team_user");

                    b.HasData(
                        new
                        {
                            Id = 100L,
                            AdminFlag = true,
                            BadgeId = "362525",
                            LoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamNo = 0,
                            Username = "362525@geekoff.onmicrosoft.com",
                            Yevent = "e21"
                        },
                        new
                        {
                            Id = 101L,
                            AdminFlag = true,
                            BadgeId = "446792",
                            LoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamNo = 0,
                            Username = "446792@geekoff.onmicrosoft.com",
                            Yevent = "e21"
                        },
                        new
                        {
                            Id = 102L,
                            AdminFlag = true,
                            BadgeId = "226250",
                            LoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamNo = 0,
                            Username = "226250@geekoff.onmicrosoft.com",
                            Yevent = "e21"
                        },
                        new
                        {
                            Id = 103L,
                            AdminFlag = true,
                            BadgeId = "288132",
                            LoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamNo = 0,
                            Username = "288132@geekoff.onmicrosoft.com",
                            Yevent = "e21"
                        },
                        new
                        {
                            Id = 104L,
                            AdminFlag = true,
                            BadgeId = "285557",
                            LoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlayerName = "Grant Hill",
                            PlayerNum = 1,
                            TeamNo = 1,
                            Username = "285557@geekoff.onmicrosoft.com",
                            WorkgroupName = "Information Technology",
                            Yevent = "e21"
                        },
                        new
                        {
                            Id = 105L,
                            AdminFlag = true,
                            BadgeId = "274798",
                            LoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TeamNo = 0,
                            Username = "274798@geekoff.onmicrosoft.com",
                            Yevent = "e21"
                        },
                        new
                        {
                            Id = 106L,
                            AdminFlag = false,
                            BadgeId = "641903",
                            LoginTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PlayerName = "Brandon Heath",
                            PlayerNum = 2,
                            TeamNo = 1,
                            Username = "641903@geekoff.onmicrosoft.com",
                            WorkgroupName = "Information Technology",
                            Yevent = "e21"
                        });
                });

            modelBuilder.Entity("GeekOff.Data.Teamreference", b =>
                {
                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.Property<int>("TeamNo")
                        .HasColumnType("integer")
                        .HasColumnName("team_no");

                    b.Property<decimal?>("Dollarraised")
                        .HasColumnType("numeric")
                        .HasColumnName("dollarraised");

                    b.Property<string>("Member1")
                        .HasColumnType("text")
                        .HasColumnName("member1");

                    b.Property<string>("Member2")
                        .HasColumnType("text")
                        .HasColumnName("member2");

                    b.Property<string>("Teamname")
                        .HasColumnType("text")
                        .HasColumnName("teamname");

                    b.Property<string>("Workgroup1")
                        .HasColumnType("text")
                        .HasColumnName("workgroup1");

                    b.Property<string>("Workgroup2")
                        .HasColumnType("text")
                        .HasColumnName("workgroup2");

                    b.HasKey("Yevent", "TeamNo");

                    b.ToTable("team_reference");

                    b.HasData(
                        new
                        {
                            Yevent = "e21",
                            TeamNo = 1,
                            Dollarraised = 1000m,
                            Member1 = "Grant Hill",
                            Member2 = "Brandon Heath",
                            Teamname = "Go Aggies",
                            Workgroup1 = "IT",
                            Workgroup2 = "IT"
                        });
                });

            modelBuilder.Entity("GeekOff.Data.UserAnswer", b =>
                {
                    b.Property<string>("Yevent")
                        .HasMaxLength(6)
                        .HasColumnType("character varying(6)")
                        .HasColumnName("yevent");

                    b.Property<int?>("RoundNo")
                        .HasColumnType("integer")
                        .HasColumnName("round_no");

                    b.Property<int>("TeamNo")
                        .HasColumnType("integer")
                        .HasColumnName("team_no");

                    b.Property<int>("QuestionNo")
                        .HasColumnType("integer")
                        .HasColumnName("question_no");

                    b.Property<DateTime>("AnswerTime")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("answer_time");

                    b.Property<string>("AnswerUser")
                        .HasColumnType("text")
                        .HasColumnName("answer_user");

                    b.Property<string>("TextAnswer")
                        .HasColumnType("text")
                        .HasColumnName("text_answer");

                    b.HasKey("Yevent", "RoundNo", "TeamNo", "QuestionNo");

                    b.ToTable("user_answer");
                });
#pragma warning restore 612, 618
        }
    }
}
